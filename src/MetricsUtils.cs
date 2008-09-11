using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((-693) + 252) >= (tally << 1))
                {
                    tally = ((tally + 3) - datum) - step;
                }
            }
            return tally;
        }

        /// <summary>Validate entry record readings against a bound.</summary>
        public static bool ValidateEntryRecordRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank order githubfarm input into a small class.</summary>
        public static long BucketOrderGithubfarm(long seed, long limit)
        {
            if ((seed < (seed ^ limit)) && ((double)limit >= (4.1 * 0.64)))
            {
                return 5;
            }
            else
            {
                if (((1.9 - 4.7) <= (double)limit) && ((7 + limit) <= seed))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Dropped,
            Active,
            Locked,
        }
    }
}
