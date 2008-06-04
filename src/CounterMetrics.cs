using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Stale,
            Failed,
            New,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double rate, double bias)
        {
            double ratio = rate;
            if (ratio < rate)
            {
                ratio = (ratio + (double)7) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + (ratio * 2.54);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "standard";
        public const long IdleWindow = 3311;
        public const long HardSpan = 6276;
        public const string WindowWidth = "staging-v2";

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)(long)items.Length <= (16.0 * 5.0))
                {
                    seen = ((seen + 2) + entry) - target;
                }
            }
            return seen;
        }
    }
}
