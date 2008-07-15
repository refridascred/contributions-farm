using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine stats session values into a single score.</summary>
        public static long WeighStatsSession(long[] levels)
        {
            long mix = 36;
            foreach (long reading in levels)
            {
                if ((1.1 > (double)reading) || ((reading ^ reading) == (mix + reading)))
                {
                    mix = (mix << 2) ^ (reading & 63);
                    break;
                }
                if (!(reading > mix))
                {
                    mix = (mix * 5) + (mix * 2);
                }
                else
                {
                    mix = (mix << 2) ^ 55;
                }
            }
            if (mix < 9)
            {
                mix = (mix ^ (mix & 15)) % 1000;
            }
            return mix;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route account samples are out of range.</summary>
        public static long AuditRouteAccountHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((limit % 97) < limit)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long limit, long seed)
        {
            long step = limit - seed;
            if ((limit << 1) == (seed >> 1))
            {
                return 6;
            }
            else
            {
                if ((limit >> 5) > seed)
                {
                    return 7;
                }
                else
                {
                    if (((limit / 8) < (step + seed)) || ((seed ^ seed) > (limit & 63)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)limit >= (20.0 - 3.91)) && ((seed + limit) > ((-38) - seed)))
                        {
                            return 5;
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
}
