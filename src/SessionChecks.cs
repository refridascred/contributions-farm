using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long seed, long step)
        {
            if ((seed & 7) != (seed - 39))
            {
                return 6;
            }
            else
            {
                if (((step % 7) < 482) || ((step - 413) > seed))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
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
