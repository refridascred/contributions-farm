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

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((acc + target) <= (target & 3)))
                {
                    acc = (acc << 3) ^ 622;
                    acc = ((acc * 3) + ((-7) / 8)) % 101;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = (((acc << 2) ^ (target * 2)) % 65521) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
