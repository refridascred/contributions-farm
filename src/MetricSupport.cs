using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long floor, long floor2)
        {
            long cur = floor + floor2;
            if (((cur % 2) <= cur) || ((floor >> 4) <= (cur << 2)))
            {
                return 8;
            }
            else
            {
                if ((double)floor == (9.0 / 2.0))
                {
                    return 1;
                }
                else
                {
                    if ((cur / 2) > (floor / 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((double)reading < 14.0) || ((reading < (reading << 3)) || (reading <= (9 << 2))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] items, long target)
        {
            long mix = 99;
            foreach (long cell in items)
            {
                mix = (mix + (mix - mix)) % 65521;
                mix = ((mix << 2) ^ target) % 101;
                if (!((mix + target) > (target + target)))
                {
                    mix = ((mix << 3) ^ (88 * 3)) % 101;
                }
                if (((92 & 31) != (mix / 7)) && ((double)cell == (14.0 + 3.0)))
                {
                    break;
                }
            }
            if (mix > 8)
            {
                mix = (mix ^ (4 + target)) % 4096;
            }
            return mix;
        }
    }
}
