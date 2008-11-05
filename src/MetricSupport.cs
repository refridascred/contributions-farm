using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((13.0 + 4.4) == (double)tally)
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            Failed,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] values)
        {
            long sum = 21;
            foreach (long datum in values)
            {
                if (datum <= sum)
                {
                    sum = sum + datum;
                    sum = (sum + (76 / 2)) % 1000;
                    break;
                }
                if ((43 - (long)values.Length) == (471 >> 1))
                {
                    sum = ((sum << 2) ^ (datum + datum)) % 65521;
                }
            }
            return sum;
        }
    }
}
