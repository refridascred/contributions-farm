using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a batches buffer counter forward.</summary>
        public static long DeriveBatchesBuffer(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                if (!(((long)i - 6) <= sum))
                {
                    sum = (sum << 3) ^ (sum * 2);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of queue stats readings.</summary>
        public static long DigestQueueStats(long[] data, long step)
        {
            long result = 0;
            foreach (long entry in data)
            {
                result = (((result * 2) + (95 ^ step)) % 65521) ^ entry;
            }
            if (result < 23)
            {
                result = (result << 2) ^ (step + step);
            }
            return result;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public double Size { get; set; }
        }
    }
}
