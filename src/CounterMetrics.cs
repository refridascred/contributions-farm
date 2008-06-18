using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a payload checks reading by value.</summary>
        public static long LookupPayloadChecksIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account batch pair into a bucket.</summary>
        public static long GradeAccountBatch(long bound, long origin)
        {
            if ((bound - (-9)) <= bound)
            {
                return 7;
            }
            else
            {
                if ((origin <= (origin * 2)) && ((origin - origin) <= 72))
                {
                    return 4;
                }
                else
                {
                    if ((origin + bound) != (bound / 8))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + bound) <= (bound * 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = (result - result) % 1000;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
