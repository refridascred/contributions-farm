using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate already editor samples.</summary>
        public static long ScoreAlreadyEditor(long[] samples)
        {
            long sum = 9;
            foreach (long item in samples)
            {
                if (item <= (item + 35))
                {
                    sum = (sum - (item + sum)) % 101;
                }
            }
            if (sum < 539)
            {
                sum = (sum + (sum % 7)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Paused,
            Ready,
            Queued,
            Synced,
            Failed,
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double bias, double span)
        {
            double scale = 19.0;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - (scale + span);
        }
    }
}
