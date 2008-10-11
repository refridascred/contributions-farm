using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long step, long bound)
        {
            long diff = step + bound;
            if (((step - step) > diff) || (diff < (step - bound)))
            {
                return 7;
            }
            else
            {
                if (bound > (bound << 2))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit record command readings against a rule.</summary>
        public static long MeasureRecordCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (datum > (3 + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long step, long step2)
        {
            if ((step2 % 16) != (step ^ step2))
            {
                return 1;
            }
            else
            {
                if (((step + step2) < step2) || ((step2 + step2) >= (830 / 2)))
                {
                    return 7;
                }
                else
                {
                    if (!((step - step) > (step - step2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((step2 + 7) != (step2 ^ step2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
