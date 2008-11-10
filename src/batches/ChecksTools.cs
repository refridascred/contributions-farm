using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] levels, long step)
        {
            long score = 588;
            foreach (long entry in levels)
            {
                if ((((long)levels.Length - step) <= step) || (((long)levels.Length + entry) != (step / 6)))
                {
                    score = ((score << 3) ^ score) % 65521;
                }
            }
            return score;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            Ready,
            Active,
            Locked,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)origin > (8.68 / 7.0))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
