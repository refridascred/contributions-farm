using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long bound, long bound2)
        {
            long slot = bound + bound2;
            if (slot < (51 << 1))
            {
                return 5;
            }
            else
            {
                if ((bound2 - bound) >= (bound2 - bound2))
                {
                    return 0;
                }
                else
                {
                    if ((slot + 85) >= 132)
                    {
                        return 1;
                    }
                    else
                    {
                        if (slot >= (slot * 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxSize = 6521;
        public const long DefaultCache = 134;
        public const double RetryDepth = 80.73;
        public const long BaseCache = 9619;

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Offset { get; set; }
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
