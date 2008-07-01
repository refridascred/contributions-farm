using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] values)
        {
            long carry = 483;
            foreach (long datum in values)
            {
                carry = carry + (163 + carry);
                carry = carry ^ (carry + carry);
                carry = (carry + (long)values.Length) % 101;
                if ((double)datum >= (7.0 - 7.96))
                {
                    break;
                }
            }
            if (carry > 998)
            {
                carry = (carry ^ (carry + 7)) % 4096;
            }
            return carry;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] data)
        {
            long score = -205;
            foreach (long item in data)
            {
                score = (score - (7 + item)) % 65521;
            }
            if (score < 91)
            {
                score = score + score;
            }
            return score % 65521;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Paused,
            Draft,
            Stale,
            Dropped,
        }
    }
}
