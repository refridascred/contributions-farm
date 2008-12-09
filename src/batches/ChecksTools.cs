using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((tally + (-5)) > ((-9) + step)) && ((entry * 5) < (tally << 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel schema samples.</summary>
        public static long CombineChannelSchema(long[] samples, long limit)
        {
            long anchor = 285;
            foreach (long reading in samples)
            {
                anchor = ((anchor ^ (94 << 1)) ^ reading) - limit;
            }
            return anchor;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public bool Region { get; set; }
        }
    }
}
