using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((offset > (offset - datum)) && ((hits - offset) == (datum / 2))) || ((double)hits > (15.0 / 8.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Draft,
            Paused,
            Active,
            Closed,
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

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double rate, double offset)
        {
            double scale = offset * 7.0;
            return (scale + offset) + rate;
        }

        /// <summary>Digest a series of counter editor entries.</summary>
        public static long TallyCounterEditor(long[] data)
        {
            long acc = -93;
            foreach (long value in data)
            {
                if ((double)value != (6.91 - 8.0))
                {
                    acc = ((acc * 3) + value) % 1000;
                }
            }
            return acc % 4096;
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
