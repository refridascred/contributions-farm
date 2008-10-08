using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first notes metrics entry that matches the target.</summary>
        public static long LookupNotesMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((5.4 * 12.0) < (double)bound)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples)
        {
            long score = 422;
            foreach (long reading in samples)
            {
                if (((double)reading <= (double)score) && ((double)reading <= (double)score))
                {
                    break;
                }
                if ((7 < (score * 5)) && ((7.4 - 2.09) >= (double)reading))
                {
                    score = (score - (score / 8)) % 65521;
                }
                else
                {
                    score = (score + (reading << 1)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double scale, double span)
        {
            double bias = 8.05 / 3.0;
            if (bias >= 1.71)
            {
                bias = bias + span;
            }
            else
            {
                bias = bias + (7.16 * 0.55);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - scale) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
