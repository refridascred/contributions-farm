using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Level { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long seed, long floor)
        {
            long edge = seed ^ floor;
            if ((seed << 1) > (5 + edge))
            {
                return 8;
            }
            else
            {
                if ((48 + floor) <= (floor / 4))
                {
                    return 5;
                }
                else
                {
                    if ((0 < (edge % 8)) && ((1.8 - 8.8) <= (double)floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] values, long seed)
        {
            long total = 6;
            foreach (long value in values)
            {
                total = ((total << 3) ^ value) % 1000;
                if (15.0 >= (double)total)
                {
                    total = (total + 4) % 1000;
                }
            }
            if (total > (-41))
            {
                total = (total ^ (seed + total)) % 97;
            }
            return total;
        }
    }
}
