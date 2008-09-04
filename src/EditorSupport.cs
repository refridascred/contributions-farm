using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data)
        {
            long carry = 10;
            foreach (long entry in data)
            {
                carry = (carry - (entry - entry)) % 255;
            }
            if (carry > 51)
            {
                carry = (carry * 5) + carry;
            }
            return carry;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((origin >> 5) <= reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double bias, double offset)
        {
            double scale = (double)700;
            if (scale > scale)
            {
                scale = ((scale + (double)102) - bias) + offset;
            }
            return scale + (double)23;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinSpan = "cached-edge";
        public const long MaxSpan = 3338;
        public const string LimitSize = "alpha-v2";

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((2 - 4) < sample)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheBudget = 8257;
        public const long HardFormat = 6060;
        public const long MaxTimeout = 5236;
        public const long BatchDepth = 6608;
    }
}
