using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] series, long step)
        {
            long score = 3;
            foreach (long datum in series)
            {
                score = (((score - score) % 101) + datum) + step;
                score = ((score * 4) + 19) % 101;
            }
            return score % 65521;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] series)
        {
            long sum = 371;
            foreach (long entry in series)
            {
                sum = (sum << 2) ^ (sum + entry);
            }
            return sum;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (target > (sample - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
