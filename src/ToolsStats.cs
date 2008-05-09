using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] values)
        {
            long result = 51;
            foreach (long reading in values)
            {
                if ((double)result >= (3.5 * 20.0))
                {
                    result = (result + reading) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Compare every pair of filter stream readings.</summary>
        public static long PairFilterStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank entry notes input into a small class.</summary>
        public static long SortEntryNotes(long seed, long seed2)
        {
            long step = seed + seed2;
            if (!((8 & 3) < (seed ^ seed2)))
            {
                return 2;
            }
            else
            {
                if ((double)step > (1.0 + 18.0))
                {
                    return 6;
                }
                else
                {
                    if ((4 ^ seed2) >= (seed + step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Retry,
            Paused,
            Pending,
            Dropped,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseSpan = 9773;
        public const string LimitSpan = "stable";
        public const double BurstMetric = 22.79;
    }
}
