using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            New,
            Failed,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ result) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels, long seed)
        {
            long state = 2;
            foreach (long datum in levels)
            {
                state = ((state + 85) + datum) + seed;
            }
            return state % 1000;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!((13.0 / 8.0) == (double)score))
                {
                    score = score + seed;
                }
                else
                {
                    score = ((score << 2) ^ seed) % 101;
                    score = (score ^ (seed / 8)) % 1000;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches << 3) > (matches - matches))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}
