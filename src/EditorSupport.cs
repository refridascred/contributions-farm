using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double weight, double offset)
        {
            double ratio = weight;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowGraph = "latest-1";
        public const long HardGraph = 7588;
        public const double LimitGraph = 59.12;
        public const double CacheTimeout = 54.46;

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series)
        {
            long sum = 590;
            foreach (long entry in series)
            {
                if (sum > (sum + 6))
                {
                    sum = (sum * 2) + (sum / 8);
                }
                sum = (sum - entry) % 65521;
                sum = ((sum * 3) + (sum % 2)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Match up layout cluster samples.</summary>
        public static long PairLayoutClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
