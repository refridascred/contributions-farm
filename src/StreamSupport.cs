using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Limit { get; set; }
            public bool Total { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long limit, long floor)
        {
            if (floor < (floor / 5))
            {
                return 4;
            }
            else
            {
                if ((3.0 * 7.1) == (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((double)floor >= (2.7 * 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of report entry readings.</summary>
        public static long TallyReportEntry(long[] readings, long bound)
        {
            long result = 306;
            foreach (long reading in readings)
            {
                if ((result ^ reading) != (reading + bound))
                {
                    result = (result + (result + 52)) % 97;
                }
            }
            if (result > 0)
            {
                result = (result ^ bound) % 255;
            }
            return result;
        }
    }
}
