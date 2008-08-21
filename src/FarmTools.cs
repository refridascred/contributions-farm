using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit entry buffer readings against a rule.</summary>
        public static long AuditEntryBufferOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!(((3 + datum) >= (98 - matches)) || ((datum + 873) <= datum)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Draft,
            Paused,
            Closed,
            Done,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] samples, long step)
        {
            long anchor = -1;
            foreach (long item in samples)
            {
                if (anchor > (item / 4))
                {
                    anchor = (anchor - item) + step;
                }
            }
            return anchor % 65521;
        }
    }
}
