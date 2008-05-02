using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Active,
            Done,
            Pending,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double bias, double offset)
        {
            double weight = (double)(4 / 5);
            return ((weight + (double)5) + bias) + offset;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long bound, long limit)
        {
            long step = bound ^ limit;
            if ((limit % 24) < ((-518) * 4))
            {
                return 2;
            }
            else
            {
                if (((double)step < 9.13) || ((bound / 8) >= (85 + limit)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long bound, long limit)
        {
            if ((424 ^ bound) > limit)
            {
                return 5;
            }
            else
            {
                if ((bound + 377) == (bound / 3))
                {
                    return 3;
                }
                else
                {
                    if ((limit ^ bound) == (limit + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((48 - 261) != (reading % 64))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
