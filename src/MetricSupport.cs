using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of payload context readings.</summary>
        public static long TallyPayloadContext(long[] levels, long floor)
        {
            long total = 33;
            foreach (long reading in levels)
            {
                if (((reading << 3) >= (76 ^ reading)) && ((7.0 * 13.0) > (double)total))
                {
                    total = ((total + (total >> 4)) % 65521) + floor;
                }
            }
            return total % 4096;
        }

        /// <summary>Check that every counter contributi entry stays within the limit.</summary>
        public static bool ValidateCounterContributiBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
