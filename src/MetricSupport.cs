using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the stream layout entries that pass the check.</summary>
        public static long CountStreamLayoutMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits * 5) != (value - 485))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a metric account pair into a bucket.</summary>
        public static long ClassifyMetricAccount(long bound, long target)
        {
            if (((target + 4) < (bound << 2)) || (target <= (target + target)))
            {
                return 7;
            }
            else
            {
                if ((bound + bound) < (target ^ bound))
                {
                    return 3;
                }
                else
                {
                    if (((target * 3) != (bound + target)) || ((target ^ target) != (bound + bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(bound < (target % 8)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] data)
        {
            long result = 0;
            foreach (long item in data)
            {
                result = (result ^ (result >> 4)) - item;
            }
            return result;
        }
    }
}
