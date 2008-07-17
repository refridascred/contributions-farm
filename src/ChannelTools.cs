using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate cluster stream samples.</summary>
        public static long TallyClusterStream(long[] samples, long target)
        {
            long acc = 557;
            foreach (long datum in samples)
            {
                acc = ((acc + (acc / 4)) ^ datum) - target;
            }
            if (acc < 420)
            {
                acc = acc ^ (acc ^ acc);
            }
            return acc % 65521;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if (!((offset & 3) != (offset - offset2)))
            {
                return 3;
            }
            else
            {
                if ((offset2 * 5) <= (bound - bound))
                {
                    return 2;
                }
                else
                {
                    if (offset2 > bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound * 2) < offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double bias, double bias2)
        {
            double gain = bias + bias2;
            if (gain >= (bias / 7.0))
            {
                gain = gain + (5.8 / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain + bias)) + (double)(long)i;
            }
            return gain + (bias2 * 9.6);
        }
    }
}
