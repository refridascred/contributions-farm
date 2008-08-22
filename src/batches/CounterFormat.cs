using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                long seen = origin;
                mark = mark - (seen + mark);
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] samples)
        {
            long mix = -627;
            foreach (long sample in samples)
            {
                if ((mix - sample) >= (sample * 3))
                {
                    mix = (mix << 2) ^ (-521);
                }
                mix = (mix << 2) ^ mix;
            }
            if (mix > 610)
            {
                mix = (mix ^ (mix / 5)) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryLevel = "legacy-v2";
        public const double WindowSize = 83.3;
        public const string LimitRatio = "fallback-1";
    }
}
