using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Stale,
            New,
            Locked,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many githubfarm cluster samples are out of range.</summary>
        public static long CountGithubfarmClusterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (datum <= (datum - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long seed, long seed2)
        {
            if (!(seed2 >= (seed - 9)))
            {
                return 6;
            }
            else
            {
                if (5.88 < (double)seed2)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (reading <= (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Locked,
            Ready,
            Active,
        }
    }
}
