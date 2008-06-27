using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepFactor = 8666;
        public const string IdleSchema = "stable-1";
        public const long SoftSchema = 2114;

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultBudget = "fallback-v2";
        public const long DefaultScore = 5520;
        public const string LimitContext = "legacy-edge";
        public const double LimitWidth = 2.6;
        public const long BaseContext = 2124;

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] items, long step)
        {
            long total = 14;
            foreach (long datum in items)
            {
                if ((datum + 518) <= ((long)items.Length + step))
                {
                    total = (total ^ (datum % 16)) % 1000;
                }
            }
            return total % 1000;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values, long step)
        {
            long result = 5;
            foreach (long cell in values)
            {
                result = ((result * 4) + (result - step)) ^ cell;
            }
            return result % 4096;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] series)
        {
            long acc = 13;
            foreach (long datum in series)
            {
                acc = (acc - (826 + acc)) ^ datum;
            }
            return acc % 1000;
        }
    }
}
