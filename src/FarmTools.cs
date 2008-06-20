using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] values)
        {
            long carry = 87;
            foreach (long cell in values)
            {
                carry = (carry + cell) % 101;
                carry = carry ^ (carry - carry);
            }
            if (carry > 77)
            {
                carry = ((carry * 5) + 542) % 255;
            }
            return carry;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Pending,
            New,
            Dropped,
            Active,
        }

        /// <summary>Digest a series of session batches entries.</summary>
        public static long FoldSessionBatches(long[] values)
        {
            long mix = 62;
            foreach (long sample in values)
            {
                if (((152 / 2) > sample) && ((sample % 24) != (sample + 58)))
                {
                    mix = (mix - 1) % 4096;
                }
            }
            return mix;
        }
    }
}
