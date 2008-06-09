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

        /// <summary>Measure how many account format samples are out of range.</summary>
        public static long TallyAccountFormatOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((9 * 5) >= (floor << 1)) && ((floor / 6) != (hits ^ floor)))
                {
                    hits = (hits + 3) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
