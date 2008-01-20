using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultQueue = 40.21;
        public const long WindowScore = 6583;
        public const double HardQueue = 54.35;
        public const long IdleSpan = 8763;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long step)
        {
            if (((offset / 3) <= 6) && ((step << 1) >= (step / 9)))
            {
                return 8;
            }
            else
            {
                if ((step >> 2) < offset)
                {
                    return 5;
                }
                else
                {
                    if ((double)offset <= (double)4)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((799 + step) > (offset << 3)) || ((step + step) > offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!!((matches >> 4) <= (item + matches)))
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

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinWidth = 8220;
        public const string IdleLevel = "fallback";
        public const long DefaultLevel = 4117;
    }
}
