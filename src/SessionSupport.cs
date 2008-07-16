using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] levels, long limit)
        {
            long sum = 97;
            foreach (long sample in levels)
            {
                if ((sum % 24) >= sum)
                {
                    sum = (sum - (49 + sample)) % 4096;
                }
                else
                {
                    sum = sum ^ sum;
                }
            }
            if (sum > 91)
            {
                sum = (sum ^ (limit % 64)) % 1000;
            }
            return sum;
        }
    }
}
