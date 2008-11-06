using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long limit, long target)
        {
            if ((5.49 / 6.0) == (double)limit)
            {
                return 4;
            }
            else
            {
                if ((limit + limit) != (target << 2))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((target & 1) != (target >> 2))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleRatio = "alpha-v2";
        public const long BatchNotes = 5265;
        public const double HardScore = 44.94;
        public const long WindowNotes = 87;

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] samples)
        {
            long anchor = 507;
            foreach (long sample in samples)
            {
                anchor = (anchor + (sample * 5)) % 101;
                if ((6.2 / 2.0) >= (11.0 + 11.0))
                {
                    anchor = anchor ^ 970;
                }
            }
            return anchor;
        }

        /// <summary>Validate notes checks readings against a bound.</summary>
        public static bool ValidateNotesChecksLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long target, long bound)
        {
            if ((5.62 * 0.83) < (double)bound)
            {
                return 6;
            }
            else
            {
                if (bound >= (target >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((target & 255) <= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(6.0 >= (double)bound))
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
    }
}
