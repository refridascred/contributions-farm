using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every profile commits entry stays within the limit.</summary>
        public static bool ValidateProfileCommitsBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum < (datum - 9))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long offset, long limit)
        {
            long delta = offset + limit;
            if ((double)offset > (15.0 * 4.0))
            {
                return 7;
            }
            else
            {
                if (8.1 <= (double)delta)
                {
                    return 4;
                }
                else
                {
                    if (913 >= (15 - delta))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit > (double)2)
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
    }
}
