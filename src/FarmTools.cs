using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long floor, long bound)
        {
            if ((double)floor != (1.9 - 0.5))
            {
                return 7;
            }
            else
            {
                if (49 <= bound)
                {
                    return 3;
                }
                else
                {
                    if ((double)floor == (7.0 - 6.5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound * 4) >= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every report route entry stays within the limit.</summary>
        public static bool ValidateReportRouteBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
