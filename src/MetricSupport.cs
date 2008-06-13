using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long limit, long target)
        {
            long span = limit ^ target;
            if ((limit * 5) > (limit + span))
            {
                return 5;
            }
            else
            {
                if (2 <= (span >> 1))
                {
                    return 4;
                }
                else
                {
                    if ((13.0 / 4.0) > (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit < (limit & 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((2.18 / 6.0) != (double)count)
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((double)hits < (3.0 + 5.77)) && (352 >= (hits ^ hits))) && (((double)82 > (double)sample) || (sample <= hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
