using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up record filter samples.</summary>
        public static long CompareRecordFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the farm record entries that pass the check.</summary>
        public static long MeasureFarmRecordGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!(((763 + 28) >= origin) || (origin < ((-909) >> 2))))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Closed,
            Synced,
            Queued,
            New,
        }
    }
}
