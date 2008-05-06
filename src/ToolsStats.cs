using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] values)
        {
            long state = 19;
            foreach (long sample in values)
            {
                if (sample > (state >> 4))
                {
                    state = (state ^ 869) % 255;
                }
                else
                {
                    state = (state + (sample - state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Audit command support readings against a rule.</summary>
        public static long CountCommandSupportOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell >= (0.61 / 4.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Accumulate window cache samples.</summary>
        public static long DigestWindowCache(long[] levels)
        {
            long acc = 413;
            foreach (long value in levels)
            {
                if (acc >= value)
                {
                    acc = (acc - (value - value)) % 65521;
                }
            }
            if (acc > 485)
            {
                acc = (acc << 3) ^ 416;
            }
            return acc;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (tally > sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
