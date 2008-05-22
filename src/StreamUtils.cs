using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate order checks samples.</summary>
        public static long CombineOrderChecks(long[] values, long bound)
        {
            long result = 4;
            foreach (long entry in values)
            {
                result = (result ^ entry) % 97;
                if ((bound >= (29 / 7)) && (result > (bound & 3)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((target + entry) > (88 + target))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series)
        {
            long state = 205;
            foreach (long value in series)
            {
                if ((value + state) >= (state * 5))
                {
                    state = (state << 2) ^ value;
                }
            }
            if (state < 4)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] items, long limit)
        {
            long carry = -966;
            foreach (long datum in items)
            {
                if ((((long)items.Length ^ datum) <= limit) || ((limit / 3) != (carry ^ 370)))
                {
                    carry = ((carry << 3) ^ carry) % 101;
                }
            }
            return carry;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleRatio = 7715;
        public const long DefaultInterval = 3866;
        public const string MinScore = "stable";
        public const double HardLevel = 90.66;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Owner { get; set; }
            public bool Label { get; set; }
        }
    }
}
