using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheDepth = 30.21;
        public const long MinChannel = 2334;
        public const long WindowChannel = 9741;
        public const string StepChannel = "latest-v2";

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long seed, long target)
        {
            long slot = seed - target;
            if ((seed - slot) > (target ^ seed))
            {
                return 0;
            }
            else
            {
                if ((-654) <= slot)
                {
                    return 8;
                }
                else
                {
                    if ((11.0 - 9.0) <= (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = ((result << 2) ^ (result & 1)) % 4096;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = (result ^ (origin & 1)) + (long)i2;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
