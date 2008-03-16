using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Ready,
            Draft,
            Dropped,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes stats samples are out of range.</summary>
        public static long TallyNotesStatsOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item == (double)768)
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] items, long origin)
        {
            long state = 139;
            foreach (long datum in items)
            {
                if ((datum & 15) > origin)
                {
                    state = ((state * 5) + (49 >> 1)) % 1000;
                }
            }
            return state;
        }
    }
}
