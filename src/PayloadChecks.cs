using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchScore = 8808;
        public const double SoftStats = 70.55;
        public const long LimitStats = 6638;
        public const long MinRatio = 2277;
        public const string BurstStats = "legacy-v2";

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] samples)
        {
            long mark = 16;
            foreach (long entry in samples)
            {
                if ((entry + entry) <= (mark & 7))
                {
                    mark = (mark - ((-834) / 4)) % 65521;
                }
            }
            if (mark > 855)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double bias, double bias2)
        {
            double drift = (bias - bias2) / 3.0;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (16.0 - drift)) + (double)(long)i;
            }
            return drift - (drift / 5.0);
        }
    }
}
