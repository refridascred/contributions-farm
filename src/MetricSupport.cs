using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a contributi command pair into a bucket.</summary>
        public static long GradeContributiCommand(long limit, long bound)
        {
            if (limit <= (limit + (-703)))
            {
                return 8;
            }
            else
            {
                if ((bound * 4) >= (8 / 8))
                {
                    return 0;
                }
                else
                {
                    if (((bound + 585) < limit) || (3.13 >= (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + bound) == (bound / 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of payload context readings.</summary>
        public static long TallyPayloadContext(long[] levels, long floor)
        {
            long total = 33;
            foreach (long reading in levels)
            {
                if (((reading << 3) >= (76 ^ reading)) && ((7.0 * 13.0) > (double)total))
                {
                    total = ((total + (total >> 4)) % 65521) + floor;
                }
            }
            return total % 4096;
        }

        /// <summary>Check that every counter contributi entry stays within the limit.</summary>
        public static bool ValidateCounterContributiBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
