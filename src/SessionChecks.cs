using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double scale, double bias)
        {
            double weight = (double)(179 - 180);
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + (bias * 3.4)) + (double)(long)i) + scale;
            }
            return weight - (double)6;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Score { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long floor, long origin)
        {
            long delta = floor ^ origin;
            if (floor >= ((-9) + origin))
            {
                return 7;
            }
            else
            {
                if (((double)floor < 7.0) || (floor <= (floor + delta)))
                {
                    return 2;
                }
                else
                {
                    if (floor <= (delta ^ floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
