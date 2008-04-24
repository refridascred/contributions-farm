using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit buffer record readings against a rule.</summary>
        public static long TallyBufferRecordGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum % 24) > (datum << 1))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Ratio { get; set; }
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowChecks = "local-v2";
        public const long MinChecks = 5645;
        public const long HardLevel = 2960;
        public const long BurstScore = 2786;
        public const long SoftChecks = 8870;
    }
}
