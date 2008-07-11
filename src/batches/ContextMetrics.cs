using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry & 127) < count)
                {
                    count = (count + 1) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value * 4) <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double ratio, double span)
        {
            double mean = (double)7 + span;
            if (mean >= (1.71 / 4.0))
            {
                mean = mean - (ratio * 17.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - 11.0) + (double)(long)i;
            }
            return mean + ratio;
        }
    }
}
