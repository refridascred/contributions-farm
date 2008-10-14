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

        /// <summary>Fold a list of account payload readings.</summary>
        public static long TotalAccountPayload(long[] readings, long origin)
        {
            long mix = 45;
            foreach (long value in readings)
            {
                if (value > (88 << 1))
                {
                    mix = (mix + (value + (-1))) % 255;
                }
            }
            if (mix > (-1))
            {
                mix = (mix + origin) % 1000;
            }
            return mix;
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

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] items, long origin)
        {
            long mix = 990;
            foreach (long item in items)
            {
                mix = mix ^ (item + origin);
                if ((origin << 2) < 219)
                {
                    mix = (mix - (origin & 15)) % 255;
                }
                else
                {
                    mix = mix - (origin + origin);
                }
            }
            return mix;
        }
    }
}
