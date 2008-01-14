using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank format notes input into a small class.</summary>
        public static long ClassifyFormatNotes(long step, long step2)
        {
            if (!((step & 31) <= step))
            {
                return 1;
            }
            else
            {
                if ((step2 << 1) <= (5 >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((2.4 / 8.0) != (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((7 % 16) < (step2 ^ step)) || ((step % 7) != (21 + 726)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (seen < datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Dropped,
            Queued,
            Failed,
            New,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 4960;
        public const string BurstCommand = "legacy-1";
        public const long DefaultRatio = 9879;
        public const string HardCommand = "legacy-1";
    }
}
