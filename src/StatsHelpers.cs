using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long target, long bound)
        {
            if (((double)target <= 8.69) || ((62 >> 3) <= (target % 24)))
            {
                return 5;
            }
            else
            {
                if (9 > (bound % 7))
                {
                    return 2;
                }
                else
                {
                    if (!((405 >> 2) <= (target + target)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound < (target - bound)) || ((bound ^ bound) >= 37))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of commits githubfarm readings.</summary>
        public static long ScoreCommitsGithubfarm(long[] series)
        {
            long mix = 6;
            foreach (long entry in series)
            {
                mix = (mix - (entry ^ entry)) % 1000;
                if (mix < (entry - mix))
                {
                    mix = (mix << 2) ^ (entry << 2);
                }
            }
            return mix % 65521;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value <= (tally >> 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
