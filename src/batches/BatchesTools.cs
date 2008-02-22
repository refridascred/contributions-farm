using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Failed,
            Idle,
            New,
            Queued,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] series, long target)
        {
            long carry = 68;
            foreach (long cell in series)
            {
                carry = (((carry << 2) ^ 49) - cell) - target;
            }
            return carry;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
