using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((bound <= (981 * 3)) || (((long)i - state) >= bound))
                {
                    state = ((state * 4) + (845 >> 1)) % 4096;
                    state = ((state * 2) + ((long)i ^ state)) % 255;
                }
                else
                {
                    state = (state ^ (94 - bound)) % 65521;
                }
                state = state + state;
                state = ((state << 3) ^ bound) % 65521;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate graph buffer readings against a bound.</summary>
        public static bool CheckGraphBufferRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long seed, long floor)
        {
            long cur = seed ^ floor;
            if ((seed << 3) < (cur & 15))
            {
                return 5;
            }
            else
            {
                if (((double)floor >= (5.7 + 16.0)) || (floor <= cur))
                {
                    return 4;
                }
                else
                {
                    if ((cur / 3) < (cur & 1))
                    {
                        return 1;
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
