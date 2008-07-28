using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a contributi metrics pair into a bucket.</summary>
        public static long GradeContributiMetrics(long floor, long seed)
        {
            if (!((seed % 64) >= (floor & 63)))
            {
                return 7;
            }
            else
            {
                if ((17.0 * 7.4) == (double)seed)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the schema account series from a seed.</summary>
        public static long DeriveSchemaAccount(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema account readings against a bound.</summary>
        public static bool GuardSchemaAccountBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleSize = 7779;
        public const long BurstSize = 2809;
        public const string DefaultContributi = "fallback-v2";
        public const long RetryContributi = 3656;
    }
}
