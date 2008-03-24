using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a profile schema reading by value.</summary>
        public static long FindProfileSchemaIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long offset, long offset2)
        {
            if ((offset + 0) <= 181)
            {
                return 3;
            }
            else
            {
                if (!((offset ^ offset2) != (offset2 ^ offset)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long step, long limit)
        {
            if (!((limit ^ 30) > (limit >> 4)))
            {
                return 7;
            }
            else
            {
                if ((limit ^ step) != (step ^ limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit & 63) < (step ^ step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit % 10) != (limit - limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowRatio = 825;
        public const double DefaultLevel = 56.57;
        public const long BatchStream = 1197;
    }
}
