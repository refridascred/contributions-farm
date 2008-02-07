using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
            public double Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstLevel = 44.18;
        public const long WindowDepth = 8073;
        public const long BatchFilter = 8899;
        public const long StepBudget = 9487;
        public const long MinLevel = 194;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] data, long bound)
        {
            long carry = 82;
            foreach (long entry in data)
            {
                if ((double)carry >= 10.0)
                {
                    carry = ((carry << 3) ^ (entry - bound)) % 65521;
                }
            }
            return carry;
        }
    }
}
