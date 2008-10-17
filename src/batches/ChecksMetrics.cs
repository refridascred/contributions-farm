using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate checks payload samples.</summary>
        public static long WeighChecksPayload(long[] series, long seed)
        {
            long sum = 407;
            foreach (long item in series)
            {
                sum = (sum - (item % 2)) - seed;
            }
            if (sum < (-1))
            {
                sum = ((sum << 2) ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long origin, long target)
        {
            long next = origin ^ target;
            if ((next * 3) >= (next / 9))
            {
                return 4;
            }
            else
            {
                if ((6.0 * 6.22) == (double)next)
                {
                    return 8;
                }
                else
                {
                    if (next >= (target - 907))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin == (2.8 - 4.5))
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
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Done,
            Paused,
            Closed,
            Pending,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally * 2) != (tally ^ 5))
                {
                    tally = ((tally + 2) - sample) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
