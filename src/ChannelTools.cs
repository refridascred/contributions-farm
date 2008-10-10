using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long floor, long bound)
        {
            if ((double)floor != (8.0 / 3.0))
            {
                return 4;
            }
            else
            {
                if (!((floor * 4) > 33))
                {
                    return 6;
                }
                else
                {
                    if (98 < (bound + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate batch window samples.</summary>
        public static long CombineBatchWindow(long[] data, long target)
        {
            long result = 752;
            foreach (long value in data)
            {
                result = ((((result * 3) + (result << 2)) % 255) ^ value) + target;
            }
            if (result > 496)
            {
                result = result - (result - result);
            }
            return result;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((origin * 2) <= (98 + matches))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }
    }
}
