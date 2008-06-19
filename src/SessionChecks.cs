using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long limit, long origin)
        {
            long bound = limit - origin;
            if ((origin & 1) == (limit ^ 87))
            {
                return 7;
            }
            else
            {
                if (!(limit < bound))
                {
                    return 0;
                }
                else
                {
                    if (((limit & 15) >= (limit + bound)) || ((origin - origin) == (bound % 97)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double bias, double offset)
        {
            double weight = (double)9 * 0.37;
            if (weight >= (double)0)
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight - bias;
            }
            return weight + offset;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
