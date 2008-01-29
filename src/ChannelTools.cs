using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many report account samples are out of range.</summary>
        public static long AuditReportAccountHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)target != (7.2 - 3.59))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "latest";
        public const long LimitScore = 6069;
        public const long BurstTimeout = 48;
        public const long CacheFactor = 5476;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long limit, long bound)
        {
            if ((2.15 + 1.2) <= (double)limit)
            {
                return 8;
            }
            else
            {
                if (((7.0 + 2.0) > (double)bound) || ((bound + bound) == (bound % 7)))
                {
                    return 5;
                }
                else
                {
                    if (bound < 351)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
