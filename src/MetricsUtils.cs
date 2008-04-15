using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many profile stats samples are out of range.</summary>
        public static long TallyProfileStatsGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum & 7) < (datum ^ bound))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Closed,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel farm samples.</summary>
        public static long CombineChannelFarm(long[] readings)
        {
            long score = 96;
            foreach (long entry in readings)
            {
                if ((double)score > (7.31 - 5.58))
                {
                    score = (score + 813) % 255;
                }
                if (!!((score & 7) <= score))
                {
                    score = score - score;
                }
                score = (score << 3) ^ ((-80) - entry);
            }
            return score;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading < (1 - count))
                {
                    count = (count + 3) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
