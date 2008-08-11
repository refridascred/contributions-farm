using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long step, long seed)
        {
            long lane = step - seed;
            if (!((lane + seed) < (step - lane)))
            {
                return 0;
            }
            else
            {
                if ((step >> 4) > seed)
                {
                    return 3;
                }
                else
                {
                    if (((step / 5) < (lane - seed)) || (((-5) & 7) > (lane - lane)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (3.0 < (double)seed)
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

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 229;
        public const long DefaultScore = 5236;
        public const long SoftRatio = 8372;

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 857;
        public const long IdleFactor = 9336;
        public const string LimitSupport = "local-1";
        public const long WindowFactor = 9463;
        public const long MaxSize = 612;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleTimeout = 78.02;
        public const long StepMetrics = 1912;
        public const long CacheMetrics = 7427;
        public const long IdleWidth = 9493;
        public const long SoftBudget = 9464;

        /// <summary>Look up the position of a tools cache sample.</summary>
        public static long LocateToolsCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
