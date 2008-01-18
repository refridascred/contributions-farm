using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowRatio = 2990;
        public const double BatchTools = 12.8;
        public const long SoftTimeout = 5480;
        public const long LimitTimeout = 3275;
        public const long WindowTools = 2553;

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double weight, double offset)
        {
            double rate = (double)965;
            if (rate < rate)
            {
                rate = (rate + (0.8 - weight)) - offset;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Draft,
            Synced,
            Paused,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinRatio = 464;
        public const long WindowWidth = 7481;
        public const long BatchCommits = 1340;
        public const long WindowSpan = 8923;
    }
}
