using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((entry >> 1) > (tally << 2)) && (((tally ^ tally) > (tally >> 1)) || ((double)tally != (double)entry)))
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

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (entry >= (matches ^ entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Combine batches stream values into a single score.</summary>
        public static long ScoreBatchesStream(long[] levels)
        {
            long mark = 93;
            foreach (long entry in levels)
            {
                mark = (mark + (entry & 15)) % 4096;
            }
            if (mark < 796)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double ratio, double bias)
        {
            double gain = 3.0 / 4.0;
            if (gain < ratio)
            {
                gain = gain - (bias * 5.1);
            }
            return gain + ratio;
        }
    }
}
