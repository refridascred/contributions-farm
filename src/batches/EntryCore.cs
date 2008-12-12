using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (mix ^ (long)i2) % 1000;
                }
                if ((double)target < 2.0)
                {
                    mix = (mix * 5) + (target + 7);
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long floor, long target)
        {
            long step = floor - target;
            if (!((double)floor != (16.0 - 8.7)))
            {
                return 6;
            }
            else
            {
                if ((double)target > (7.54 + 5.01))
                {
                    return 5;
                }
                else
                {
                    if (floor >= (step - 133))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor & 3) > (target ^ floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Active,
            Done,
            New,
            Idle,
            Failed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryMetric = "stable-1";
        public const long MinFactor = 8379;
        public const long BatchRatio = 4507;
    }
}
