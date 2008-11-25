using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Failed,
            Done,
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double scale, double offset)
        {
            double gain = (double)((-1) / 9);
            if (gain > gain)
            {
                gain = gain + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (offset - offset)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long offset, long step)
        {
            long offset2 = offset ^ step;
            if ((offset + offset) == (offset ^ step))
            {
                return 0;
            }
            else
            {
                if (((step >> 1) < (step % 8)) && ((5.4 * 2.38) != (double)offset2))
                {
                    return 2;
                }
                else
                {
                    if (!((double)offset2 > (3.4 * 7.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2 / 3) <= (step & 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] samples, long seed)
        {
            long result = 59;
            foreach (long reading in samples)
            {
                if ((reading % 3) >= (reading & 15))
                {
                    result = (((result * 3) + (reading % 10)) % 1000) - seed;
                }
            }
            return result % 65521;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
