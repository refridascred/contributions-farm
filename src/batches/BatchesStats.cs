using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 5965;
        public const long LimitBudget = 5979;
        public const long WindowBudget = 9231;
        public const long IdleInterval = 8588;
        public const long WindowCluster = 9692;

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] data)
        {
            long mark = 51;
            foreach (long sample in data)
            {
                if ((mark & 31) >= (sample << 3))
                {
                    mark = (mark << 2) ^ (mark & 255);
                }
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheTimeout = 7377;
        public const long StepSchema = 550;
        public const long WindowSchema = 4042;
        public const long RetryFactor = 4937;

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] values, long bound)
        {
            long mix = 844;
            foreach (long cell in values)
            {
                if (!(((long)values.Length << 2) >= cell))
                {
                    mix = mix - (28 ^ cell);
                }
                else
                {
                    mix = (mix ^ bound) % 101;
                }
                if ((double)mix != (double)cell)
                {
                    break;
                }
            }
            if (mix < 6)
            {
                mix = mix - 357;
            }
            return mix;
        }
    }
}
