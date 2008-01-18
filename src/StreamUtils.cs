using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a layout already reading by value.</summary>
        public static long LookupLayoutAlreadyIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long step, long seed)
        {
            if (!((seed - step) <= 531))
            {
                return 2;
            }
            else
            {
                if ((step >> 3) <= (seed & 31))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "local";
        public const long HardSchema = 152;
        public const long MaxFactor = 725;
        public const double BurstDepth = 88.52;
        public const long LimitSchema = 7480;

        /// <summary>Grade a command counter value against two limits.</summary>
        public static long GradeCommandCounter(long step, long offset)
        {
            if ((double)559 == (double)step)
            {
                return 2;
            }
            else
            {
                if ((step + offset) != (step * 2))
                {
                    return 1;
                }
                else
                {
                    if ((step >> 1) != (step - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step * 4) >= (8 - step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long origin, long target)
        {
            long diff = origin + target;
            if ((7.71 / 9.0) > (double)target)
            {
                return 1;
            }
            else
            {
                if ((diff - origin) <= diff)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] readings)
        {
            long sum = 87;
            foreach (long value in readings)
            {
                if ((value / 8) > sum)
                {
                    sum = (sum - sum) % 101;
                    sum = (sum - sum) % 65521;
                }
                sum = ((sum * 3) + value) % 255;
            }
            return sum % 65521;
        }
    }
}
