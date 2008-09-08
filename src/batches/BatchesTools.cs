using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Active,
            Closed,
            Locked,
            Idle,
            Draft,
        }

        /// <summary>Check that every format channel entry stays within the limit.</summary>
        public static bool VerifyFormatChannelRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Limit { get; set; }
            public bool Count { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }
    }
}
