using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!((561 & 127) < (tally + 8)) || (tally > (tally / 4)))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long origin, long bound)
        {
            if (((origin - bound) == (origin - origin)) || (bound < (origin * 5)))
            {
                return 4;
            }
            else
            {
                if (((double)bound <= (double)412) && (bound >= (origin ^ bound)))
                {
                    return 1;
                }
                else
                {
                    if ((origin % 12) <= (bound << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((79 <= (bound << 1)) || ((bound & 127) >= bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session already samples are out of range.</summary>
        public static long CountSessionAlreadyMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits ^ value) < (value ^ 167))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
