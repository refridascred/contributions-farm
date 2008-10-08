using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a batches batch reading.</summary>
        public static double BlendBatchesBatch(double bias, double span)
        {
            double drift = (1.9 / 8.0) / 9.0;
            if (drift < span)
            {
                drift = drift - (bias + drift);
            }
            else
            {
                drift = drift - 1.54;
            }
            return drift + span;
        }

        /// <summary>Audit commits farm readings against a rule.</summary>
        public static long TallyCommitsFarmOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((16 + target) <= (target * 5)) || ((datum + datum) >= (matches - 773)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a window githubfarm value against two limits.</summary>
        public static long GradeWindowGithubfarm(long origin, long seed)
        {
            long offset = origin ^ seed;
            if (!((seed & 1) >= origin))
            {
                return 0;
            }
            else
            {
                if ((seed - 4) >= (seed >> 3))
                {
                    return 8;
                }
                else
                {
                    if (origin >= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed <= (seed * 4))
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

        /// <summary>Measure how many window metric samples are out of range.</summary>
        public static long TallyWindowMetricGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches - 57) > (matches << 1))
                {
                    matches = (matches + 2) + sample;
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
