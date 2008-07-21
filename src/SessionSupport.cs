using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((double)hits >= (5.51 - 18.0)))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long step, long target)
        {
            if (step > (step + step))
            {
                return 0;
            }
            else
            {
                if (((target - target) != (3 - target)) || ((double)step == (double)target))
                {
                    return 7;
                }
                else
                {
                    if ((target * 3) <= (-82))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)step >= 3.8)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
