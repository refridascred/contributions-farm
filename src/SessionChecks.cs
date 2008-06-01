using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (7.1 >= (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long origin, long offset)
        {
            long edge = origin + offset;
            if (edge > (offset << 3))
            {
                return 0;
            }
            else
            {
                if ((edge + origin) >= origin)
                {
                    return 2;
                }
                else
                {
                    if ((offset - 0) < offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 7139;
        public const long CacheEntry = 4586;
        public const double LimitEntry = 71.6;
        public const double CacheSize = 86.34;
        public const long MinRatio = 6181;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Mode { get; set; }
            public bool Token { get; set; }
            public long Size { get; set; }
            public double Level { get; set; }
        }
    }
}
