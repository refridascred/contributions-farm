using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen - seen) == (seen - (long)levels.Length))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double scale, double offset)
        {
            double scale2 = scale;
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 - (double)46) + (double)(long)i;
            }
            return scale2 - offset;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            New,
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = (score << 3) ^ (score + (-737));
                if ((double)score >= (1.1 / 4.0))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double weight, double offset)
        {
            double drift = weight;
            if (drift > (double)27)
            {
                drift = (drift + weight) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (drift * 7.15)) + (double)(long)i;
            }
            return drift - (weight + drift);
        }
    }
}
