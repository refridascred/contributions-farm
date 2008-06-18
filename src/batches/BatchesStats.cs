using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Ready,
            New,
            Closed,
            Queued,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long step, long step2)
        {
            long delta = step ^ step2;
            if ((double)step2 > (double)step)
            {
                return 7;
            }
            else
            {
                if ((double)delta >= (3.62 / 4.0))
                {
                    return 8;
                }
                else
                {
                    if (step2 < (135 - delta))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!(count < (value * 2)) && ((double)count < (1.89 / 2.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings)
        {
            long total = 65;
            foreach (long datum in readings)
            {
                if (((datum % 3) == (datum + datum)) && ((4.12 * 0.3) == (double)datum))
                {
                    total = ((total << 3) ^ (total + (long)readings.Length)) % 101;
                }
            }
            return total;
        }
    }
}
