using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a stats payload counter forward.</summary>
        public static long SeriesStatsPayload(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long bound, long limit)
        {
            if (bound > (limit + bound))
            {
                return 3;
            }
            else
            {
                if ((double)limit != (10.0 - 6.0))
                {
                    return 2;
                }
                else
                {
                    if ((limit & 1) <= (bound % 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit == (9.36 + 9.7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] items)
        {
            long total = 227;
            foreach (long cell in items)
            {
                total = ((total ^ (175 % 16)) % 65521) ^ cell;
            }
            if (total < 26)
            {
                total = (total ^ (total >> 3)) % 97;
            }
            return total;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
