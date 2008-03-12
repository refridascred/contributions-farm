using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((entry + seen) != (floor ^ 1)) && ((seen + 9) < (entry >> 4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Retry,
            Active,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Roll a editor layout counter forward.</summary>
        public static long RollEditorLayout(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor - (7 + (long)i)) % 4096;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] samples)
        {
            long result = 762;
            foreach (long cell in samples)
            {
                result = (result << 2) ^ (cell + cell);
            }
            return result;
        }
    }
}
