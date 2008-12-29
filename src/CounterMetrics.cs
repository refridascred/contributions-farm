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

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long step, long offset)
        {
            long next = step - offset;
            if (!((step - step) > step))
            {
                return 0;
            }
            else
            {
                if (((offset + step) >= step) && (next < (offset % 2)))
                {
                    return 7;
                }
                else
                {
                    if ((325 > (step & 31)) && ((87 + offset) <= (step + offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
