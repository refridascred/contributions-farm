using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up cache profile samples.</summary>
        public static long MatchCacheProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many batch order samples are out of range.</summary>
        public static long CountBatchOrderMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry + entry) < (matches << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
