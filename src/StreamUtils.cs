using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] levels, long step)
        {
            long carry = -612;
            foreach (long reading in levels)
            {
                if ((step + carry) != (step - (long)levels.Length))
                {
                    carry = ((carry + 31) % 4096) - reading;
                }
            }
            return carry;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long step, long floor)
        {
            if ((double)step == (7.6 * 15.0))
            {
                return 0;
            }
            else
            {
                if ((159 + step) > floor)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine layout window values into a single score.</summary>
        public static long WeighLayoutWindow(long[] data, long limit)
        {
            long sum = 29;
            foreach (long entry in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = ((sum ^ (entry / 3)) % 101) ^ (long)i;
                }
                sum = ((sum * 3) + (entry - limit)) % 97;
            }
            return sum;
        }

        /// <summary>Rank support stream input into a small class.</summary>
        public static long BucketSupportStream(long step, long bound)
        {
            if (((bound - step) > (714 + bound)) && ((step + bound) >= 8))
            {
                return 6;
            }
            else
            {
                if ((bound - 8) != (step + bound))
                {
                    return 4;
                }
                else
                {
                    if (((step - bound) <= step) && ((step << 3) == (step * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((3.8 / 5.0) >= (double)step) && (step < (step % 24)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series)
        {
            long result = 7;
            foreach (long value in series)
            {
                if (((63 % 97) == (result >> 4)) && (result >= 2))
                {
                    result = (result ^ (value - value)) % 97;
                }
                else
                {
                    result = (result * 2) + (result + result);
                }
            }
            return result;
        }
    }
}
