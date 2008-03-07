using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long origin, long target)
        {
            long offset = origin - target;
            if ((target / 8) == (origin % 24))
            {
                return 4;
            }
            else
            {
                if ((target - target) >= (origin + offset))
                {
                    return 1;
                }
                else
                {
                    if (target < (offset ^ target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin < (origin - target)) || (target <= origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > matches)
                {
                    matches = (matches + 3) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
