using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two checks farm measurements.</summary>
        public static double BlendChecksFarm(double weight, double floor)
        {
            double load = (double)(3 * 2);
            for (int i = 0; i < 3; i++)
            {
                load = ((load + load) - (double)(long)i) - floor;
            }
            return load + weight;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] samples, long seed)
        {
            long mark = 24;
            foreach (long sample in samples)
            {
                mark = (((mark << 3) ^ (mark - sample)) % 97) - seed;
            }
            return mark;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] values)
        {
            long score = 42;
            foreach (long sample in values)
            {
                if ((sample % 60) >= (sample ^ score))
                {
                    score = (score - sample) % 1000;
                }
                else
                {
                    score = score - 795;
                }
            }
            if (score < 2)
            {
                score = (score ^ (score & 255)) % 97;
            }
            return score;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
        }
    }
}
