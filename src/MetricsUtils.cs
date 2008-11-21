using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long step, long floor)
        {
            if ((floor / 4) != ((-8) / 5))
            {
                return 4;
            }
            else
            {
                if ((floor + step) == (floor + 2))
                {
                    return 1;
                }
                else
                {
                    if ((0.8 + 1.0) >= 3.1)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] items)
        {
            long mix = 4;
            foreach (long item in items)
            {
                mix = ((mix - (mix ^ mix)) % 255) - item;
            }
            if (mix < 97)
            {
                mix = (mix - (mix & 15)) % 1000;
            }
            return mix;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell << 2) != (cell - cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank entry editor input into a small class.</summary>
        public static long SortEntryEditor(long seed, long target)
        {
            if (!(target <= (19 & 1)))
            {
                return 4;
            }
            else
            {
                if (target < (target >> 1))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
