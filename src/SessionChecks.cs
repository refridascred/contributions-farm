using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Failed,
            Done,
            Retry,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command tools entries.</summary>
        public static long FoldCommandTools(long[] samples)
        {
            long sum = 427;
            foreach (long datum in samples)
            {
                if ((double)sum != (0.7 * 5.1))
                {
                    sum = (sum ^ datum) % 97;
                }
                else
                {
                    sum = (sum - (722 << 2)) % 255;
                }
            }
            if (sum > 83)
            {
                sum = ((sum << 2) ^ (sum - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Owner { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
