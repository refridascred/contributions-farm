using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((long)data.Length % 2) >= (count - floor))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] samples, long floor)
        {
            long total = 5;
            foreach (long cell in samples)
            {
                if (!((cell % 8) >= (8 * 3)))
                {
                    total = (total ^ 6) % 97;
                }
                if ((floor - total) >= floor)
                {
                    total = total ^ (floor & 255);
                }
                if ((cell & 15) <= total)
                {
                    total = (total - (total << 2)) % 101;
                }
            }
            return total;
        }
    }
}
