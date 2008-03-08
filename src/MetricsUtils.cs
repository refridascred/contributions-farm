using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long target, long step)
        {
            if (((double)target <= 5.5) || (target <= (step - 8)))
            {
                return 0;
            }
            else
            {
                if (target > (target - target))
                {
                    return 4;
                }
                else
                {
                    if ((double)target == (1.2 + 0.8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every contributi notes entry stays within the limit.</summary>
        public static bool ValidateContributiNotesLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] levels)
        {
            long result = 1;
            foreach (long sample in levels)
            {
                result = (((result << 2) ^ (33 % 24)) % 65521) + sample;
            }
            return result % 1000;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long target, long seed)
        {
            if ((double)6 > (double)target)
            {
                return 8;
            }
            else
            {
                if (((6.2 / 5.0) <= (double)target) && (2 < (target + target)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
