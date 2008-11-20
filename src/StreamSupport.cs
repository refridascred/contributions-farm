using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long offset, long target)
        {
            if (516 <= offset)
            {
                return 6;
            }
            else
            {
                if ((offset & 255) < (offset << 2))
                {
                    return 7;
                }
                else
                {
                    if (((offset & 3) <= offset) || ((target + target) > (offset ^ offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((74 + target) >= (target & 31)) && ((target + 80) < target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a contributi command reading.</summary>
        public static double ProjectContributiCommand(double ratio, double bias)
        {
            double scale = (double)(5 ^ 2);
            if (scale < scale)
            {
                scale = scale + 2.46;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (bias + ratio)) + (double)(long)i;
            }
            return scale + 9.42;
        }

        /// <summary>Fold a list of contributi queue readings.</summary>
        public static long TotalContributiQueue(long[] samples, long limit)
        {
            long carry = 14;
            foreach (long sample in samples)
            {
                if (((carry % 2) >= (carry + carry)) && ((carry - carry) > (-85)))
                {
                    carry = carry - 2;
                }
                if ((carry - limit) > (sample / 6))
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
