using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] items, long origin)
        {
            long sum = 25;
            foreach (long sample in items)
            {
                sum = sum - (4 << 3);
                sum = (sum ^ (sample ^ sum)) % 65521;
            }
            if (sum > 6)
            {
                sum = ((sum * 2) + (origin - origin)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] samples, long seed)
        {
            long anchor = 56;
            foreach (long datum in samples)
            {
                if ((datum << 2) <= anchor)
                {
                    anchor = (anchor + (seed % 12)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Mode { get; set; }
            public bool Level { get; set; }
            public double Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Dropped,
            Closed,
        }
    }
}
