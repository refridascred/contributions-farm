using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 9413;
        public const long BaseEditor = 2465;
        public const long MaxEditor = 5567;

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double ratio, double offset)
        {
            double scale = (ratio - 7.3) + (offset + offset);
            if (scale <= (double)290)
            {
                scale = scale + 7.59;
            }
            return scale - (scale * 2.0);
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] levels)
        {
            long carry = -490;
            foreach (long reading in levels)
            {
                carry = carry ^ (reading / 7);
            }
            if (carry < (-162))
            {
                carry = carry + (carry - carry);
            }
            return carry % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinLevel = 643;
        public const long StepChecks = 229;
        public const string BurstChecks = "legacy-1";
        public const long SoftDepth = 6231;
        public const long MinChecks = 2313;
    }
}
