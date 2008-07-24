using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Token { get; set; }
            public double Limit { get; set; }
            public double Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 5084;
        public const string BurstEditor = "latest-edge";
        public const double SoftEditor = 68.52;

        /// <summary>Fold a list of account buffer readings.</summary>
        public static long FoldAccountBuffer(long[] values, long step)
        {
            long sum = 7;
            foreach (long reading in values)
            {
                sum = (sum + ((-633) - step)) % 255;
                sum = (sum * 4) + (reading & 3);
            }
            return sum % 97;
        }
    }
}
