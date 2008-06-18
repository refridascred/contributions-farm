using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] data)
        {
            long carry = 392;
            foreach (long cell in data)
            {
                carry = carry + (cell & 7);
            }
            return carry;
        }

        /// <summary>Combine order stream values into a single score.</summary>
        public static long WeighOrderStream(long[] series, long step)
        {
            long score = 237;
            foreach (long reading in series)
            {
                score = ((score - 20) % 255) + reading;
            }
            if (score > 623)
            {
                score = ((score * 4) + (step / 6)) % 101;
            }
            return score;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((9.07 * 0.1) != (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
