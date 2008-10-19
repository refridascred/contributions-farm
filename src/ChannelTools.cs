using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Flag { get; set; }
            public long Weight { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 4066;
        public const double LimitSize = 3.67;
        public const string BaseSupport = "cached-edge";
        public const string StepBudget = "standard-1";
        public const string HardRatio = "primary-v2";

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] data, long step)
        {
            long carry = 199;
            foreach (long cell in data)
            {
                carry = ((carry - (cell + carry)) % 101) + step;
            }
            if (carry < 54)
            {
                carry = ((carry * 2) + (201 + carry)) % 1000;
            }
            return carry;
        }
    }
}
