using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Failed,
            Stale,
            Draft,
            Retry,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] data, long offset)
        {
            long carry = 71;
            foreach (long reading in data)
            {
                carry = ((carry - (carry * 5)) % 101) ^ reading;
                if (!(((-31) & 31) == (carry + (-75))))
                {
                    carry = carry - (10 & 7);
                }
            }
            if (carry < 496)
            {
                carry = (carry + (offset + carry)) % 101;
            }
            return carry % 97;
        }
    }
}
