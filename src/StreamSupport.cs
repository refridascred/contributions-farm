using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of batches checks readings.</summary>
        public static long TallyBatchesChecks(long[] values)
        {
            long anchor = 2;
            foreach (long item in values)
            {
                anchor = anchor - (item + anchor);
                if (!((item ^ item) >= anchor))
                {
                    anchor = (anchor - anchor) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Total { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
        }
    }
}
