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

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                long hits = (state >> 5) / 4;
                if (hits <= (state - 70))
                {
                    break;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
