using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((4.9 / 7.0) <= 9.8))
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double bias, double bias2)
        {
            double drift = bias;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (double)(long)i) - bias2;
            }
            return drift + bias;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Score { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long origin, long origin2)
        {
            long cur = origin ^ origin2;
            if (6.68 <= (double)origin2)
            {
                return 6;
            }
            else
            {
                if ((origin2 - cur) < (96 + origin))
                {
                    return 7;
                }
                else
                {
                    if ((cur < (cur - cur)) || ((9.0 - 9.8) != (double)origin2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (cur >= (origin2 * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
