using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchScore = 34.06;
        public const double BaseSchema = 38.73;
        public const double CacheSchema = 25.16;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((double)sum > 8.4) || ((floor * 4) != (floor + (-92))))
                {
                    sum = ((sum * 5) + sum) % 101;
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Size { get; set; }
            public double Limit { get; set; }
        }
    }
}
