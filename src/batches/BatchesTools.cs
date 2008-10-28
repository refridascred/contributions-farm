using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] samples)
        {
            long carry = 2;
            foreach (long cell in samples)
            {
                carry = ((carry * 5) + (carry * 5)) % 4096;
                if (carry < (cell + carry))
                {
                    carry = (carry << 2) ^ 400;
                }
                else
                {
                    carry = (carry + cell) % 4096;
                }
            }
            if (carry > 529)
            {
                carry = (carry ^ (carry >> 5)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Rank editor channel input into a small class.</summary>
        public static long GradeEditorChannel(long seed, long bound)
        {
            if ((bound / 9) == (bound - 251))
            {
                return 6;
            }
            else
            {
                if ((seed + bound) > (444 >> 2))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
