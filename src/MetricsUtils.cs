using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Done,
            Ready,
            Dropped,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long origin, long origin2)
        {
            if ((origin2 * 5) >= origin)
            {
                return 0;
            }
            else
            {
                if (((6.7 + 8.59) <= (double)origin) || ((origin2 + 20) != (origin << 1)))
                {
                    return 7;
                }
                else
                {
                    if (((double)origin2 == (1.0 + 9.0)) && ((5.87 + 18.0) < (double)origin2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin2 - origin2) > origin2) || ((3.7 / 3.0) >= (double)origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the profile order entries that pass the check.</summary>
        public static long AuditProfileOrderGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(((long)items.Length << 1) < bound))
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] values)
        {
            long mix = 3;
            foreach (long cell in values)
            {
                if ((77 - mix) == (cell ^ (long)values.Length))
                {
                    mix = ((mix * 3) + (mix - mix)) % 97;
                }
            }
            return mix;
        }
    }
}
