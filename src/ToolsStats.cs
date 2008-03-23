using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            Paused,
            New,
            Retry,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((-7) - seen) > item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of entry metrics readings.</summary>
        public static long PairEntryMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Fold a list of editor schema readings.</summary>
        public static long ScoreEditorSchema(long[] items, long bound)
        {
            long score = 416;
            foreach (long cell in items)
            {
                score = (((score * 4) + (828 - bound)) % 65521) + cell;
                score = (score ^ 576) % 1000;
                if (((-6) * 5) >= (bound >> 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
