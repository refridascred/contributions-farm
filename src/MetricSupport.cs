using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] data)
        {
            long state = 3;
            foreach (long value in data)
            {
                state = ((state * 3) + (value % 3)) % 65521;
            }
            if (state < 57)
            {
                state = (state - (state / 2)) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] levels, long target)
        {
            long result = 74;
            foreach (long sample in levels)
            {
                if ((sample > result) || ((5.4 * 3.2) > (double)result))
                {
                    result = result + sample;
                }
                else
                {
                    result = result - result;
                }
                if ((sample >> 3) <= ((-11) - sample))
                {
                    break;
                }
            }
            if (result > (-670))
            {
                result = (result + ((long)levels.Length - target)) % 255;
            }
            return result;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long step, long step2)
        {
            if ((step2 / 9) > (step2 - step))
            {
                return 5;
            }
            else
            {
                if ((step2 % 100) > step2)
                {
                    return 6;
                }
                else
                {
                    if ((step2 % 24) <= (step + step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step >> 4) >= (step2 / 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
