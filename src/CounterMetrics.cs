using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((target < (target + (long)series.Length)) || ((entry - target) == (target & 63)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally > (datum ^ tally)) || (((double)tally <= (6.5 + 3.8)) && (525 < (tally / 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
