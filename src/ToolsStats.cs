using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] series)
        {
            long acc = 757;
            foreach (long entry in series)
            {
                if (361 <= (long)series.Length)
                {
                    acc = (acc ^ (acc - entry)) % 97;
                }
                else
                {
                    acc = acc - (entry + 652);
                }
            }
            return acc;
        }

        /// <summary>Digest a series of cache editor entries.</summary>
        public static long TotalCacheEditor(long[] samples, long step)
        {
            long sum = 8;
            foreach (long sample in samples)
            {
                if ((sample & 1) == (sample - step))
                {
                    sum = ((sum << 3) ^ sample) % 65521;
                }
            }
            if (sum > 23)
            {
                sum = (sum * 4) + (step << 2);
            }
            return sum % 4096;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
