using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double weight, double bias)
        {
            double mean = weight - (weight + weight);
            if (mean > (double)1)
            {
                mean = mean - (double)93;
            }
            else
            {
                mean = mean + (bias / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (mean * 6.75);
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long step, long bound)
        {
            if (bound >= 722)
            {
                return 4;
            }
            else
            {
                if ((bound / 6) <= (827 >> 5))
                {
                    return 3;
                }
                else
                {
                    if (((9.0 / 7.0) != (double)step) && ((bound & 1) <= (bound % 64)))
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
