using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Closed,
            Stale,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double offset)
        {
            double bias = offset;
            if (bias < offset)
            {
                bias = bias - (double)0;
            }
            else
            {
                bias = bias + (double)65;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (ratio + 4.9);
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double rate, double floor)
        {
            double gain = (double)39 - 6.0;
            if (gain < (double)986)
            {
                gain = (gain + (gain - 4.8)) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (9.8 * 3.5)) + (double)(long)i;
            }
            return gain - (3.0 + floor);
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading <= (283 + hits)) || !(reading >= (8 >> 3)))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
