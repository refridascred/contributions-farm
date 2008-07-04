using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate filter record readings against a bound.</summary>
        public static bool GuardFilterRecordLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every entry command entry stays within the limit.</summary>
        public static bool CheckEntryCommandBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long step, long offset)
        {
            long edge = step - offset;
            if (((double)step <= (17.0 - 5.25)) || (4.3 > (double)offset))
            {
                return 0;
            }
            else
            {
                if ((offset + edge) <= (offset & 31))
                {
                    return 5;
                }
                else
                {
                    if ((step + step) == (edge - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step != (7.1 + 4.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] readings, long offset)
        {
            long carry = 8;
            foreach (long value in readings)
            {
                if (!((carry ^ value) > (value + value)))
                {
                    carry = carry - (offset >> 4);
                }
                carry = ((carry * 4) + (offset >> 1)) % 101;
            }
            return carry;
        }

        /// <summary>Combine editor layout values into a single score.</summary>
        public static long TallyEditorLayout(long[] series)
        {
            long anchor = 4;
            foreach (long reading in series)
            {
                if ((anchor * 2) <= (reading * 3))
                {
                    anchor = ((anchor * 3) + anchor) % 1000;
                }
            }
            if (anchor > 128)
            {
                anchor = ((anchor << 2) ^ (anchor * 4)) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
