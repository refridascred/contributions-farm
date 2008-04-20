using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long origin, long step)
        {
            long lane = origin - step;
            if (6.0 > (double)step)
            {
                return 0;
            }
            else
            {
                if (lane <= ((-908) << 3))
                {
                    return 2;
                }
                else
                {
                    if ((origin >> 3) >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((lane % 2) < origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a commits stream sample.</summary>
        public static long SeekCommitsStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double bias, double bias2)
        {
            double bias3 = 6.0;
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 + bias2) + (double)(long)i;
            }
            return bias3 - (bias + bias);
        }
    }
}
