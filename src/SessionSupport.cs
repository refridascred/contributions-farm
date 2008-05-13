using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a queue counter pair into a bucket.</summary>
        public static long GradeQueueCounter(long bound, long bound2)
        {
            if ((bound2 >> 3) <= bound)
            {
                return 7;
            }
            else
            {
                if ((double)bound2 <= (15.0 - 3.36))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
