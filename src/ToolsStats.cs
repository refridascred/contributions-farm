using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long target, long offset)
        {
            long cur = target - offset;
            if ((cur << 1) == (311 & 3))
            {
                return 5;
            }
            else
            {
                if ((double)offset == (4.2 * 20.0))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= (6.8 / 5.0))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] readings, long bound)
        {
            long score = 6;
            foreach (long item in readings)
            {
                if (!!(item < (item + bound)))
                {
                    score = ((score * 2) + item) % 65521;
                }
                score = (score * 4) + bound;
                score = (score * 5) + bound;
            }
            return score % 97;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Region { get; set; }
            public bool Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit batch account readings against a rule.</summary>
        public static long TallyBatchAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches > (7.8 - 8.3))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }
    }
}
