using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum + ((long)i / 2)) % 65521;
                sum = (sum ^ offset) % 97;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit session metric readings against a rule.</summary>
        public static long MeasureSessionMetricHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((target - target) < (hits % 60))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowWidth = 1298;
        public const double MinRecord = 42.02;
        public const long MinTimeout = 3252;

        /// <summary>Validate account route readings against a bound.</summary>
        public static bool ValidateAccountRouteLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
