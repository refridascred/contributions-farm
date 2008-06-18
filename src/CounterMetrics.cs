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

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] values, long limit)
        {
            long mix = 86;
            foreach (long cell in values)
            {
                if (8.59 > (double)mix)
                {
                    mix = ((mix << 3) ^ (limit ^ mix)) ^ cell;
                }
            }
            return mix;
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
