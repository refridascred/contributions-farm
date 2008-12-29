using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of cluster route readings.</summary>
        public static long DigestClusterRoute(long[] samples)
        {
            long state = 582;
            foreach (long item in samples)
            {
                if ((item + item) != (item ^ state))
                {
                    state = (state + (state + state)) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Token { get; set; }
            public bool Rank { get; set; }
            public double Count { get; set; }
        }
    }
}
