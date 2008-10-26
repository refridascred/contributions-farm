using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long step, long floor)
        {
            long step2 = step ^ floor;
            if ((step << 3) > (step2 * 5))
            {
                return 2;
            }
            else
            {
                if (((564 * 3) <= step2) && (74 < (floor ^ 6)))
                {
                    return 7;
                }
                else
                {
                    if (step2 > floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series)
        {
            long score = -725;
            foreach (long item in series)
            {
                if ((double)score != (3.0 - 1.0))
                {
                    score = score + (item % 64);
                }
            }
            if (score > 888)
            {
                score = score - (score + 618);
            }
            return score % 97;
        }
    }
}
