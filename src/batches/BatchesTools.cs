using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long carry = 35;
            foreach (long sample in values)
            {
                carry = (carry ^ 807) % 65521;
                if (((carry + (-4)) > (sample - carry)) && (6.0 < (double)carry))
                {
                    carry = (carry * 3) + sample;
                    carry = carry - (carry * 5);
                }
                if (!(32 > (carry >> 4)))
                {
                    carry = (carry ^ 5) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
