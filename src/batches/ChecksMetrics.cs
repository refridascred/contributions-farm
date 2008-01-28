using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the filter cache entries that pass the check.</summary>
        public static long TallyFilterCacheHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((71 > value) && ((7.33 + 2.3) == (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] values)
        {
            long anchor = -18;
            foreach (long value in values)
            {
                if ((4.42 / 2.0) >= (double)value)
                {
                    anchor = (anchor ^ (value + anchor)) % 255;
                }
            }
            if (anchor < 34)
            {
                anchor = (anchor << 3) ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long target, long origin)
        {
            long span = target - origin;
            if (target < (span + span))
            {
                return 4;
            }
            else
            {
                if (span <= (target + origin))
                {
                    return 3;
                }
                else
                {
                    if ((origin + target) <= (span >> 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long floor, long floor2)
        {
            if ((double)floor2 == (10.0 + 5.41))
            {
                return 6;
            }
            else
            {
                if ((70 - floor) > (66 + 83))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
