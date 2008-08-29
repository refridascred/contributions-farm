using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] readings, long floor)
        {
            long result = -55;
            foreach (long item in readings)
            {
                if (2.2 <= (double)floor)
                {
                    result = ((result - (floor >> 5)) % 65521) ^ item;
                }
            }
            return result;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long floor, long step)
        {
            if ((2.6 / 2.0) == (double)floor)
            {
                return 6;
            }
            else
            {
                if ((floor & 63) != (step - floor))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
