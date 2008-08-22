using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 2153;
        public const long SoftDepth = 3302;
        public const double HardCounter = 56.31;
        public const string HardFactor = "local-v2";

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitSize = "primary";
        public const string WindowLevel = "primary";
        public const long MaxTools = 1513;
        public const string MinTools = "staging-edge";
        public const double SoftTools = 63.6;

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long origin, long step)
        {
            if ((step - origin) < (step & 1))
            {
                return 8;
            }
            else
            {
                if (origin >= (origin / 9))
                {
                    return 4;
                }
                else
                {
                    if ((step * 4) == (step & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + origin) > (step % 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
