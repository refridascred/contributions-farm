using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Failed,
            Closed,
            Retry,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long bound, long seed)
        {
            if ((5.96 - 0.16) >= (6.0 + 1.82))
            {
                return 8;
            }
            else
            {
                if (seed >= (bound >> 5))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
