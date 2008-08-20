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

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCommits = "local-v2";
        public const long IdleBudget = 4467;
        public const long WindowCommits = 1471;
        public const long LimitLevel = 2556;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
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
