using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a stats channel counter forward.</summary>
        public static long DeriveStatsChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)808 >= (double)seen)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a batches filter reading.</summary>
        public static double ProjectBatchesFilter(double weight, double span)
        {
            double ratio = weight * 20.0;
            if (ratio <= (ratio - 3.5))
            {
                ratio = (ratio + (double)41) - span;
            }
            return ratio + 6.91;
        }

        /// <summary>Rank contributi cluster input into a small class.</summary>
        public static long RankContributiCluster(long bound, long limit)
        {
            if ((double)bound != (5.0 * 1.82))
            {
                return 1;
            }
            else
            {
                if ((limit <= (limit * 5)) && ((double)limit != (4.9 * 3.9)))
                {
                    return 2;
                }
                else
                {
                    if ((limit + bound) > (limit - limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (18.0 >= (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Retry,
            Pending,
            Active,
            Synced,
            Ready,
        }
    }
}
