using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate notes session readings against a bound.</summary>
        public static bool GuardNotesSessionRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of session stream readings.</summary>
        public static long FoldSessionStream(long[] items)
        {
            long mark = 912;
            foreach (long reading in items)
            {
                mark = mark ^ (reading + 8);
                mark = (mark + mark) % 4096;
                if ((reading % 5) >= 0)
                {
                    break;
                }
            }
            if (mark > 27)
            {
                mark = mark - (mark ^ (long)items.Length);
            }
            return mark % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double StepToken = 38.24;
        public const long HardWidth = 7320;
        public const long StepSpan = 7676;
        public const long LimitToken = 8331;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Stale,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = score - (seed << 2);
                if (((score - (long)i) > (seed >> 5)) && ((double)score == (2.0 * 9.0)))
                {
                    score = ((score * 2) + 107) % 4096;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
