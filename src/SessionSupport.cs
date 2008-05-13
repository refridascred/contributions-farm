using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepSize = 9845;
        public const double DefaultReport = 23.04;
        public const long IdleBudget = 517;
    }
}
