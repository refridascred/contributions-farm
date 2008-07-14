using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Owner { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double gain, double bias)
        {
            double ratio = 18.0;
            if (ratio < (2.4 / 8.0))
            {
                ratio = (ratio - gain) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + 9.12) - (double)(long)i;
            }
            return ratio + (double)(-303);
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
