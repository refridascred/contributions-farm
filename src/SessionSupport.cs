using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of schema stream readings.</summary>
        public static long ScoreSchemaStream(long[] data)
        {
            long state = 8;
            foreach (long cell in data)
            {
                state = (((state << 3) ^ 21) % 101) + cell;
            }
            return state % 97;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Count { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
