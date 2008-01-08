using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate record session samples.</summary>
        public static long CombineRecordSession(long[] data, long seed)
        {
            long sum = 1;
            foreach (long item in data)
            {
                if ((seed + sum) != (sum + 7))
                {
                    sum = (((sum * 2) + (long)data.Length) % 255) ^ item;
                }
                if (sum > (sum >> 1))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long origin, long floor)
        {
            long span = origin + floor;
            if (((origin + 66) > floor) || ((14.0 * 20.0) >= (double)span))
            {
                return 6;
            }
            else
            {
                if (!((span / 5) > origin))
                {
                    return 0;
                }
                else
                {
                    if (((floor + floor) <= (origin & 3)) && ((origin ^ 236) == (origin >> 1)))
                    {
                        return 5;
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
