using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Count { get; set; }
            public string Token { get; set; } = "";
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public double Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Rank format session input into a small class.</summary>
        public static long GradeFormatSession(long floor, long offset)
        {
            long next = floor ^ offset;
            if ((double)offset <= (9.7 / 5.0))
            {
                return 5;
            }
            else
            {
                if ((offset + next) <= 131)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (99 <= (matches / 2))
                {
                    matches = ((matches + 1) ^ datum) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Dropped,
            Active,
        }
    }
}
