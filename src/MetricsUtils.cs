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

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long target, long bound)
        {
            long step = target + bound;
            if (bound < (bound << 2))
            {
                return 0;
            }
            else
            {
                if (!((bound / 7) == (bound + target)))
                {
                    return 7;
                }
                else
                {
                    if (target >= 7)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target % 97) != (step << 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
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
