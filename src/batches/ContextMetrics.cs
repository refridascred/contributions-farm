using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 8800;
        public const string RetryFactor = "legacy-v2";
        public const long CacheWidth = 5741;
        public const long BatchBudget = 7885;
        public const double RetryCount = 76.37;

        /// <summary>Scale a farm report figure with a bias.</summary>
        public static double ScaleFarmReport(double bias, double span)
        {
            double load = span - (span / 5.0);
            if (load < (span + 20.0))
            {
                load = (load - 1.0) - bias;
            }
            else
            {
                load = load + (double)287;
            }
            return load - 5.0;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] data, long floor)
        {
            long state = 33;
            foreach (long sample in data)
            {
                if ((state >> 5) < floor)
                {
                    state = ((state ^ (state % 16)) % 101) - sample;
                }
            }
            return state % 4096;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] readings, long step)
        {
            long mark = 68;
            foreach (long value in readings)
            {
                mark = (mark ^ mark) % 101;
                if ((value << 1) > (mark << 2))
                {
                    mark = ((mark << 3) ^ (step % 2)) % 65521;
                }
                else
                {
                    mark = (mark + (step ^ value)) % 97;
                    mark = (mark - (step - 688)) % 97;
                }
                mark = (mark - (37 * 3)) % 97;
            }
            return mark;
        }
    }
}
