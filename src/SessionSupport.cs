using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardDepth = 2720;
        public const long MinTimeout = 5486;
        public const long HardAlready = 296;
        public const double SoftScore = 32.2;

        /// <summary>Count the editor channel entries that pass the check.</summary>
        public static long MeasureEditorChannelGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((214 & 3) != (seen - seen))
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
