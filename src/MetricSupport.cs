using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a notes commits reading by value.</summary>
        public static long SeekNotesCommitsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally > (tally - tally))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Grade a entry metrics value against two limits.</summary>
        public static long BucketEntryMetrics(long target, long step)
        {
            if ((double)step != (2.6 / 7.0))
            {
                return 0;
            }
            else
            {
                if (((double)target > (double)step) || (target <= (step * 3)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
