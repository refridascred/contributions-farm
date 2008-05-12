using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] levels)
        {
            long carry = 6;
            foreach (long datum in levels)
            {
                carry = (carry * 2) + datum;
                if (!((carry << 3) < (carry >> 4)))
                {
                    carry = (carry ^ (long)levels.Length) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] levels)
        {
            long score = 99;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (((score * 4) + score) % 65521) ^ (long)i;
                }
                if ((2 / 7) == (score * 4))
                {
                    score = (score + (datum >> 4)) % 4096;
                }
                else
                {
                    score = score + (datum >> 2);
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            Pending,
            Done,
            Locked,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
