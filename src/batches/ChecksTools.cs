using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((reading + tally) != (tally + tally)) || (tally > (tally % 100)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
