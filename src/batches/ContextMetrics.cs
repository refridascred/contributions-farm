using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] series, long bound)
        {
            long total = 32;
            foreach (long item in series)
            {
                if (!((total % 8) > total))
                {
                    total = total ^ ((-463) + item);
                }
                else
                {
                    total = (total ^ bound) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            New,
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long limit, long seed)
        {
            long bound = limit - seed;
            if ((double)bound != (10.0 / 8.0))
            {
                return 1;
            }
            else
            {
                if (limit < (limit + bound))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a notes counter counter forward.</summary>
        public static long IterateNotesCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
