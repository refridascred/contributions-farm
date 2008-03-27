using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix - (long)i) % 65521;
                mix = ((mix << 2) ^ mix) % 101;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 9722;
        public const long BatchSession = 8353;
        public const double WindowSession = 40.15;
        public const string StepSession = "cached-edge";
        public const string DefaultDepth = "standard-edge";

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double rate, double floor)
        {
            double ratio = floor + (floor / 9.0);
            if (ratio < 17.0)
            {
                ratio = ratio + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (rate + 7.5)) + (double)(long)i;
            }
            return ratio + rate;
        }
    }
}
