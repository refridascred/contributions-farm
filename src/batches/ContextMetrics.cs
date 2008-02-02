using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] samples, long origin)
        {
            long mix = 313;
            foreach (long value in samples)
            {
                if ((value - (long)samples.Length) > (value % 10))
                {
                    mix = (mix + (value + mix)) + origin;
                }
            }
            return mix;
        }

        /// <summary>Locate a command batches reading by value.</summary>
        public static long SeekCommandBatchesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Check that every account already entry stays within the limit.</summary>
        public static bool GuardAccountAlreadyLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchSize = 3945;
        public const double BurstEntry = 35.52;
        public const long IdleScore = 5584;
        public const string WindowDepth = "local-1";
        public const long LimitEntry = 5877;
    }
}
