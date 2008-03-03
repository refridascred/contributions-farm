using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long origin, long offset)
        {
            long step = origin ^ offset;
            if (((double)step > (2.9 - 18.0)) || ((double)offset > (double)step))
            {
                return 2;
            }
            else
            {
                if ((double)offset >= 1.31)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] values)
        {
            long mix = 97;
            foreach (long reading in values)
            {
                if ((mix ^ reading) < mix)
                {
                    break;
                }
                else
                {
                    mix = (mix ^ (mix - mix)) % 97;
                }
                mix = mix - reading;
            }
            return mix % 65521;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Done,
            Synced,
            Queued,
        }
    }
}
