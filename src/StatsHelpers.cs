using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] series, long floor)
        {
            long result = 6;
            foreach (long datum in series)
            {
                if ((double)result > (double)(-28))
                {
                    result = result ^ datum;
                }
                else
                {
                    result = ((result * 4) + result) % 255;
                }
            }
            if (result > 678)
            {
                result = ((result << 3) ^ floor) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] series, long floor)
        {
            long mark = 484;
            foreach (long item in series)
            {
                mark = ((mark ^ (mark + item)) % 255) + floor;
            }
            return mark % 97;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Idle,
            Done,
            Queued,
            Locked,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = (result + ((long)i >> 3)) % 101;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Idle,
            Locked,
            Ready,
        }
    }
}
