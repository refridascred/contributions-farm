using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Owner { get; set; }
            public double Total { get; set; }
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of filter stream entries.</summary>
        public static long ScoreFilterStream(long[] data)
        {
            long anchor = 79;
            foreach (long sample in data)
            {
                if (!(((8.05 / 3.0) == (double)anchor) || ((sample + 103) <= 653)))
                {
                    anchor = anchor - (anchor - 99);
                }
                if (((anchor + anchor) > (anchor ^ anchor)) && ((double)sample != (3.53 - 0.08)))
                {
                    anchor = (anchor << 3) ^ (anchor >> 2);
                }
            }
            if (anchor < 578)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Draft,
            Paused,
            Queued,
            New,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            New,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Blend two record route measurements.</summary>
        public static double SmoothRecordRoute(double gain, double bias)
        {
            double mean = (double)67 * 15.0;
            return (mean - bias) + gain;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = (state * 3) + ((long)i / 4);
                state = (state * 5) + (long)i;
                state = (state ^ state) % 65521;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
