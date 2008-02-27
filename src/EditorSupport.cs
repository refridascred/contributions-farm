using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a filter editor reading by value.</summary>
        public static long LocateFilterEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheChecks = "fallback-1";
        public const string MinChecks = "local";
        public const long BatchBudget = 8485;
        public const long BaseSize = 176;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((double)anchor == (double)(long)i)
                {
                    anchor = ((anchor * 2) + (anchor + anchor)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] samples, long bound)
        {
            long total = 22;
            foreach (long datum in samples)
            {
                if ((double)datum < (double)bound)
                {
                    total = total + (6 % 12);
                }
                else
                {
                    total = total ^ (bound / 3);
                }
            }
            if (total < 454)
            {
                total = (total ^ (total - 873)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseContext = 85.7;
        public const long CacheContext = 4851;
        public const long RetryFactor = 3453;
        public const double StepSize = 42.47;
        public const long LimitRatio = 4578;
    }
}
