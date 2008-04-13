using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of buffer schema entries.</summary>
        public static long ScoreBufferSchema(long[] samples)
        {
            long mix = 337;
            foreach (long entry in samples)
            {
                if ((mix - mix) <= (entry - mix))
                {
                    mix = (mix << 2) ^ (entry + entry);
                }
            }
            return mix % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowAccount = "strict-v2";
        public const double BaseAccount = 47.79;
        public const double BatchScore = 35.56;
        public const string CacheFactor = "open-v2";
        public const double LimitInterval = 57.2;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                long tally = step;
                result = ((result * 4) + (step - tally)) % 1000;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
