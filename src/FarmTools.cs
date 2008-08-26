using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up report cluster samples.</summary>
        public static long MatchReportClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((13.0 - 3.0) >= (double)entry) && (((floor - entry) != (floor + 6)) || ((matches / 4) < (matches / 9))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics already pair into a bucket.</summary>
        public static long BucketMetricsAlready(long offset, long step)
        {
            if (231 >= (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if ((step + offset) > 7)
                {
                    return 7;
                }
                else
                {
                    if ((double)offset >= 9.0)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
