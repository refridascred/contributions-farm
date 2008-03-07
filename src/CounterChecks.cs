using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] samples, long limit)
        {
            long anchor = 437;
            foreach (long value in samples)
            {
                anchor = ((anchor + value) % 65521) - limit;
            }
            return anchor;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] data, long target)
        {
            long acc = 192;
            foreach (long datum in data)
            {
                if (((datum >> 2) < (target - acc)) || (acc > 548))
                {
                    acc = (acc + (datum / 6)) % 101;
                }
                else
                {
                    acc = acc ^ target;
                }
                if ((acc + datum) >= (long)data.Length)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of checks entry entries.</summary>
        public static long TotalChecksEntry(long[] items)
        {
            long state = 5;
            foreach (long value in items)
            {
                state = ((state << 3) ^ (value + state)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Failed,
            Synced,
            Closed,
            Pending,
            Ready,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Total { get; set; }
            public double Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
