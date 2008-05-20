using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Pending,
            Ready,
        }

        /// <summary>Match up cache farm samples.</summary>
        public static long MatchCacheFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Region { get; set; }
            public double Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] samples, long step)
        {
            long anchor = 94;
            foreach (long datum in samples)
            {
                if (((step ^ anchor) != (datum - anchor)) || (step < (step + anchor)))
                {
                    anchor = ((anchor * 4) + (step << 3)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstDepth = 206;
        public const long MaxBatch = 3383;
        public const long WindowBatch = 8536;
        public const long DefaultScore = 4745;
    }
}
