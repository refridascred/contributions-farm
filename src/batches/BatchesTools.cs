using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Locked,
            Draft,
            Failed,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches * 2) >= ((long)series.Length + 862))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }
    }
}
