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

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples)
        {
            long result = -1;
            foreach (long item in samples)
            {
                if (((result + (-1)) < result) && (result < (result * 2)))
                {
                    result = ((result * 3) + item) % 255;
                }
            }
            if (result > (-4))
            {
                result = (result + (result << 2)) % 97;
            }
            return result % 97;
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
