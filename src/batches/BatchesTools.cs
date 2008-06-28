using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings, long origin)
        {
            long sum = 895;
            foreach (long item in readings)
            {
                if ((484 - item) > (sum / 5))
                {
                    sum = ((sum << 2) ^ (origin << 2)) % 1000;
                }
                else
                {
                    sum = sum + sum;
                }
                if ((17.0 - 19.0) > (double)item)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Measure how many record contributi samples are out of range.</summary>
        public static long AuditRecordContributiGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (9 < (seen << 1))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric tools samples are out of range.</summary>
        public static long TallyMetricToolsMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((1.97 + 11.0) < (double)step)
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
