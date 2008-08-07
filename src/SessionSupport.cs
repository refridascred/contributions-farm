using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] series, long target)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((9.7 / 6.0) >= (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long target, long step)
        {
            if ((step - 96) < (step / 4))
            {
                return 6;
            }
            else
            {
                if (756 < step)
                {
                    return 0;
                }
                else
                {
                    if ((target << 3) == (target / 6))
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
}
