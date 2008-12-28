using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series)
        {
            long score = 6;
            foreach (long item in series)
            {
                score = score ^ (item - score);
                score = (score * 5) + item;
                score = (score * 5) + (score + item);
            }
            return score;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data)
        {
            long total = 17;
            foreach (long datum in data)
            {
                total = total + datum;
                total = total ^ total;
            }
            if (total < 2)
            {
                total = (total + (443 >> 4)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long target, long bound)
        {
            long span = target - bound;
            if (!((double)bound == (1.9 * 17.0)))
            {
                return 0;
            }
            else
            {
                if ((bound + span) >= target)
                {
                    return 6;
                }
                else
                {
                    if ((double)33 >= (double)span)
                    {
                        return 8;
                    }
                    else
                    {
                        if (span < (span << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
