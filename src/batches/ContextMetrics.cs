using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix << 2) ^ (mix + (long)i)) ^ (long)i2;
                }
                if ((double)mix >= (16.0 + 9.0))
                {
                    mix = (mix << 3) ^ floor;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Retry,
            Pending,
            Active,
            New,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long bound, long step)
        {
            if ((bound - 7) < bound)
            {
                return 0;
            }
            else
            {
                if ((step & 15) < bound)
                {
                    return 2;
                }
                else
                {
                    if ((step ^ step) == (bound / 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((bound ^ (-253)) > 5) && ((step ^ bound) != (bound ^ bound)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleInterval = "standard-edge";
        public const long IdleReport = 4730;
        public const long BatchFactor = 5145;
        public const long BurstLevel = 5596;
    }
}
