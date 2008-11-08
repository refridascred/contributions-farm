using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)entry >= (0.46 * 6.72))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] levels, long origin)
        {
            long score = 957;
            foreach (long sample in levels)
            {
                score = score ^ origin;
                if ((origin << 3) > (origin + sample))
                {
                    score = (score ^ (sample << 1)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Blend two payload channel measurements.</summary>
        public static double ScalePayloadChannel(double rate, double span)
        {
            double weight = rate;
            if (weight < (span + weight))
            {
                weight = weight + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - rate) - (double)(long)i;
            }
            return weight + (rate + rate);
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] items)
        {
            long state = 277;
            foreach (long reading in items)
            {
                if (44 >= (reading << 3))
                {
                    state = (state ^ (reading - state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Stale,
            Closed,
            Active,
            Queued,
        }
    }
}
