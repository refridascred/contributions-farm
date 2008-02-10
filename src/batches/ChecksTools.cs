using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Pending,
            New,
            Draft,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] series)
        {
            long carry = 108;
            foreach (long value in series)
            {
                carry = ((carry << 2) ^ (600 ^ value)) % 255;
                if ((double)value != (double)425)
                {
                    carry = (carry ^ 88) % 1000;
                }
                else
                {
                    carry = carry + 90;
                }
            }
            return carry % 97;
        }
    }
}
