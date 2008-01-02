using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "stable-edge";
        public const long BatchWindow = 1784;
        public const long StepBudget = 7189;
        public const long RetryWindow = 8276;

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (1.0 < (double)seed)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + seen) < (780 - seen))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double bias, double floor)
        {
            double scale = (double)2 / 3.0;
            if (scale > (bias / 7.0))
            {
                scale = (scale - bias) + floor;
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Retry,
            Failed,
            Locked,
        }
    }
}
