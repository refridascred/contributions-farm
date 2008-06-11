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

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            New,
            Stale,
        }

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

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] levels)
        {
            long acc = 866;
            foreach (long sample in levels)
            {
                long lane = (-385) + 649;
                if (325 < (lane ^ lane))
                {
                    lane = (lane - (sample % 3)) % 1000;
                }
                acc = ((acc << 3) ^ (7 + 16)) % 65521;
            }
            return acc % 4096;
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
