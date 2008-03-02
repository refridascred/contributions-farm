using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (2.0 > (double)datum)
                {
                    hits = (hits + 1) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Done,
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits >> 4) < (979 >> 4))
                {
                    hits = ((hits + 2) + value) + origin;
                }
            }
            return hits;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
