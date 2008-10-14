using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Active,
            Synced,
            Pending,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long offset, long step)
        {
            if (!((2.7 * 3.93) != (double)offset))
            {
                return 4;
            }
            else
            {
                if (((offset + 31) != (50 * 3)) && ((double)step == (16.0 * 9.21)))
                {
                    return 0;
                }
                else
                {
                    if (!((offset & 15) <= step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset + step) >= (step + step)) || ((double)step <= (double)offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next metrics notes value.</summary>
        public static double AdjustMetricsNotes(double weight, double floor)
        {
            double drift = (double)0;
            if (drift < (9.84 * 3.4))
            {
                drift = (drift - (floor / 6.0)) - weight;
            }
            else
            {
                drift = drift - (drift / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (floor / 7.0)) - (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Accumulate cache command samples.</summary>
        public static long FoldCacheCommand(long[] readings)
        {
            long sum = 21;
            foreach (long item in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = (((sum << 3) ^ (item % 24)) % 101) - (long)i;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = (sum << 2) ^ (350 >> 3);
                    sum = (sum - ((long)i2 + 1)) % 65521;
                }
                sum = ((sum << 3) ^ (sum - item)) % 1000;
            }
            if (sum < 5)
            {
                sum = sum + (sum << 3);
            }
            return sum % 1000;
        }
    }
}
