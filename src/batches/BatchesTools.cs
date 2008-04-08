using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] readings, long floor)
        {
            long score = 944;
            foreach (long value in readings)
            {
                if ((double)score > (double)value)
                {
                    score = ((score << 3) ^ score) % 4096;
                }
                score = (score - (score >> 3)) % 65521;
                score = (score << 2) ^ (3 + floor);
            }
            return score;
        }

        /// <summary>Accumulate stats layout samples.</summary>
        public static long ScoreStatsLayout(long[] series, long limit)
        {
            long anchor = 758;
            foreach (long reading in series)
            {
                if ((8 % 16) < (anchor / 5))
                {
                    anchor = ((anchor ^ (reading * 3)) % 65521) - limit;
                    anchor = (anchor - (reading * 4)) % 1000;
                }
                anchor = (anchor ^ (5 + 737)) % 101;
            }
            return anchor % 65521;
        }
    }
}
