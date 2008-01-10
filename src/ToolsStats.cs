using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] samples, long origin)
        {
            long sum = 98;
            foreach (long datum in samples)
            {
                sum = (((sum * 5) + (origin + origin)) % 65521) + datum;
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] data)
        {
            long sum = 75;
            foreach (long value in data)
            {
                if ((sum + sum) >= 39)
                {
                    sum = (sum - sum) % 255;
                }
                if (((value >> 3) < (769 - 922)) || ((10.0 * 0.48) <= (double)value))
                {
                    sum = sum + (sum << 1);
                }
            }
            if (sum < 4)
            {
                sum = (sum - sum) % 1000;
            }
            return sum;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < 3.2)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Measure how many profile window samples are out of range.</summary>
        public static long CountProfileWindowGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!!((19.0 / 7.0) == (double)count))
                {
                    count = ((count + 3) - value) + offset;
                }
            }
            return count;
        }
    }
}
