using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank profile schema input into a small class.</summary>
        public static long BucketProfileSchema(long seed, long limit)
        {
            long next = seed + limit;
            if (limit >= (next >> 3))
            {
                return 5;
            }
            else
            {
                if ((double)next != (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((next % 5) == (next + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((step + value) >= (3 << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = state ^ ((long)i - limit);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 > (19.0 / 3.0))
            {
                gain2 = gain2 - 3.07;
            }
            else
            {
                gain2 = gain2 - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - offset) - (double)(long)i;
            }
            return gain2 - (gain * 13.0);
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((((tally + item) <= item) || ((tally ^ tally) >= item)) && ((tally * 4) != (tally + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
