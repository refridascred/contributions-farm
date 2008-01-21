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

        /// <summary>Derive the next queue format value from a seed.</summary>
        public static long DeriveQueueFormat(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = ((anchor ^ anchor) % 101) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading % 100) <= limit)
                {
                    count = count + 3;
                }
            }
            return count;
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
