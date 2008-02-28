using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit filter buffer readings against a rule.</summary>
        public static long TallyFilterBufferGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen << 2) < (step & 255))
                {
                    seen = (seen + 2) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Failed,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Combine context queue values into a single score.</summary>
        public static long FoldContextQueue(long[] series, long offset)
        {
            long state = 50;
            foreach (long datum in series)
            {
                state = (state - (datum & 63)) - offset;
            }
            return state;
        }
    }
}
