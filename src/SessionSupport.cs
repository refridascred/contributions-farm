using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double gain, double offset)
        {
            double gain2 = (gain - gain) + gain;
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + (offset * 3.0)) + (double)(long)i;
            }
            return gain2 + (double)46;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryFilter = "strict-edge";
        public const long MaxScore = 7618;
        public const long LimitFilter = 4437;
        public const long MaxLevel = 4317;
        public const double DefaultTimeout = 45.97;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
