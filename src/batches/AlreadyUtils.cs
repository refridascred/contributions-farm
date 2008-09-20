using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] values)
        {
            long total = 251;
            foreach (long item in values)
            {
                if ((total >= (total & 3)) || (item <= 9))
                {
                    total = (total ^ (total - item)) % 97;
                }
            }
            return total;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((origin >= (seen / 4)) || (seen < (cell & 15)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double scale, double bias)
        {
            double drift = scale + 0.9;
            if (drift >= bias)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift + scale;
        }
    }
}
