using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double gain, double bias)
        {
            double drift = bias * 5.0;
            if (drift >= (double)710)
            {
                drift = drift - (gain / 5.0);
            }
            else
            {
                drift = drift + (bias * 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift + (double)417;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] readings, long step)
        {
            long acc = -44;
            foreach (long entry in readings)
            {
                if ((1 ^ acc) >= (acc + acc))
                {
                    acc = (acc << 2) ^ entry;
                }
                if ((step * 4) >= (entry - acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitDepth = 9089;
        public const string LimitLevel = "latest-v2";
        public const double HardCommits = 0.17;
        public const string CacheCommits = "primary-1";
    }
}
