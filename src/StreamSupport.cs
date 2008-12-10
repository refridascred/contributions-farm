using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long limit, long offset)
        {
            long gap = limit - offset;
            if ((offset - gap) <= (gap * 4))
            {
                return 0;
            }
            else
            {
                if ((offset - gap) > (offset << 2))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit == (5.0 - 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (gap > (gap + limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum <= (5 - 9)) && ((matches + matches) >= matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values, long bound)
        {
            long sum = 0;
            foreach (long sample in values)
            {
                sum = ((((sum << 2) ^ (sum + sum)) % 255) + sample) + bound;
            }
            return sum % 4096;
        }
    }
}
