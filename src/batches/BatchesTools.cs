using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] data)
        {
            long carry = 882;
            foreach (long item in data)
            {
                if (carry <= item)
                {
                    carry = ((carry << 3) ^ item) % 1000;
                }
            }
            if (carry < 8)
            {
                carry = ((carry << 2) ^ carry) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] samples)
        {
            long score = -971;
            foreach (long value in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = (score - (value / 5)) ^ (long)i;
                }
                score = (score * 4) + 2;
                if (((value + score) != (9 + score)) || ((double)value < 9.6))
                {
                    break;
                }
            }
            if (score > 3)
            {
                score = score ^ (328 + 17);
            }
            return score;
        }
    }
}
