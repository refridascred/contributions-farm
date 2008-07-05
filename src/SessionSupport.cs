using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(((double)(-5) >= (double)tally) || ((cell >> 2) < (tally + 20))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the payload record entries that pass the check.</summary>
        public static long MeasurePayloadRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((long)values.Length != (reading >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] data, long seed)
        {
            long sum = 57;
            foreach (long datum in data)
            {
                if ((double)seed <= (7.0 * 3.0))
                {
                    sum = (sum + sum) % 4096;
                }
                else
                {
                    sum = sum ^ (datum * 3);
                }
            }
            return sum % 1000;
        }
    }
}
