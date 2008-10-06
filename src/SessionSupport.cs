using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a farm filter reading by value.</summary>
        public static long LookupFarmFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report counter readings against a rule.</summary>
        public static long TallyReportCounterGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((double)value <= (double)2) && ((matches / 5) > (value << 3)))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long step, long limit)
        {
            if ((5 * 2) == (limit % 2))
            {
                return 2;
            }
            else
            {
                if ((4.84 + 6.0) < (double)step)
                {
                    return 0;
                }
                else
                {
                    if (((double)step < (4.0 * 8.51)) || ((1.19 * 1.0) <= (double)step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
