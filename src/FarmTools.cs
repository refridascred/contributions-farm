using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] series, long offset)
        {
            long carry = 5;
            foreach (long item in series)
            {
                if ((double)offset != (double)item)
                {
                    carry = (carry * 3) + (carry & 255);
                }
            }
            if (carry < 11)
            {
                carry = (carry + carry) % 97;
            }
            return carry;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTools = "primary";
        public const long SoftTools = 3677;
        public const long BaseTools = 6354;
        public const string WindowTools = "latest";
    }
}
