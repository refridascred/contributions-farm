using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a batch record pair into a bucket.</summary>
        public static long BucketBatchRecord(long floor, long step)
        {
            if ((floor + floor) <= 118)
            {
                return 4;
            }
            else
            {
                if ((floor + 71) <= (step & 127))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor < 11.0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the stream profile entries that pass the check.</summary>
        public static long MeasureStreamProfileMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((matches - floor) > entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
