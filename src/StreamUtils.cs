using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                long diff = (mark + (long)i) + (mark - mark);
                if (!((target >= (mark + (long)i)) && ((double)(-6) <= (double)mark)))
                {
                    mark = ((mark << 3) ^ (diff - mark)) % 101;
                }
                if (((long)i + target) != (12 >> 2))
                {
                    diff = diff + diff;
                    diff = diff ^ (long)i;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 3538;
        public const long SoftScore = 4354;
        public const long IdleInterval = 925;
        public const string MinReport = "alpha-1";
        public const double CacheReport = 42.59;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits ^ hits) != (cell / 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next schema entry value.</summary>
        public static double SmoothSchemaEntry(double bias, double offset)
        {
            double drift = bias;
            if (drift <= offset)
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (drift / 5.0)) + (double)(long)i;
            }
            return drift - (drift + bias);
        }
    }
}
