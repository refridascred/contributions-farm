using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
            public double Level { get; set; }
        }
    }
}
