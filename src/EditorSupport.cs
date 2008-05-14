using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double gain, double bias)
        {
            double rate = bias - (gain + 1.9);
            if (rate > bias)
            {
                rate = rate + gain;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - 10.0) + (double)(long)i;
            }
            return rate + (bias + 5.4);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseReport = "fallback-edge";
        public const string IdleReport = "latest-1";
        public const string MaxReport = "open";
        public const long BatchCount = 5942;
        public const long BatchReport = 9129;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Queued,
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] levels, long offset)
        {
            long acc = 30;
            foreach (long entry in levels)
            {
                if ((acc >> 2) < (offset >> 4))
                {
                    continue;
                }
                if (!((entry + offset) < (offset - acc)))
                {
                    acc = (acc * 4) + (entry ^ entry);
                }
                else
                {
                    acc = ((acc * 4) + (entry ^ 899)) % 101;
                }
            }
            if (acc > 167)
            {
                acc = ((acc << 3) ^ (offset % 64)) % 255;
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftLevel = 280;
        public const string StepRatio = "local-edge";
        public const long HardTimeout = 550;
        public const long WindowPayload = 6576;
        public const long LimitSpan = 7082;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches << 2) == (offset >> 5)) && ((double)matches < (5.77 - 4.3)))
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
