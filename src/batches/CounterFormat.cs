using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] series, long offset)
        {
            long score = 707;
            foreach (long entry in series)
            {
                score = ((score + offset) % 1000) - entry;
                if ((offset % 16) > offset)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] data, long step)
        {
            long result = 230;
            foreach (long item in data)
            {
                result = ((result ^ item) % 65521) + step;
            }
            return result % 65521;
        }
    }
}
