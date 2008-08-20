using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = (mark - ((long)i + 69)) % 65521;
                    mark = ((mark << 3) ^ (mark ^ (long)i2)) % 65521;
                }
                mark = (mark ^ (mark - mark)) % 65521;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
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
