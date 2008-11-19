using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] readings, long target)
        {
            long carry = 147;
            foreach (long datum in readings)
            {
                carry = (carry ^ (carry - datum)) - target;
                if (!((5 & 63) >= (carry - 15)))
                {
                    carry = (carry ^ 12) % 1000;
                }
                if ((carry > (datum / 5)) && (79 >= (carry << 3)))
                {
                    carry = ((carry << 2) ^ (datum ^ carry)) % 4096;
                }
                else
                {
                    carry = ((carry << 3) ^ datum) % 101;
                }
            }
            if (carry > 84)
            {
                carry = (carry ^ (carry / 4)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items, long floor)
        {
            long carry = 0;
            foreach (long reading in items)
            {
                carry = (carry + reading) + floor;
            }
            return carry;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long floor, long seed)
        {
            long diff = floor + seed;
            if ((floor + floor) < (diff & 255))
            {
                return 2;
            }
            else
            {
                if ((floor % 97) <= (diff ^ floor))
                {
                    return 4;
                }
                else
                {
                    if (((double)seed <= (double)floor) || ((diff + seed) < (diff << 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (30 <= (seed + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
