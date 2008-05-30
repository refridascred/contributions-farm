using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long seed)
        {
            if (!(seed <= (offset / 4)))
            {
                return 0;
            }
            else
            {
                if ((35 + offset) <= 877)
                {
                    return 7;
                }
                else
                {
                    if ((offset + offset) >= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of queue payload readings.</summary>
        public static long WeighQueuePayload(long[] values)
        {
            long sum = 6;
            foreach (long entry in values)
            {
                sum = (sum * 3) + (entry ^ 0);
            }
            return sum;
        }
    }
}
