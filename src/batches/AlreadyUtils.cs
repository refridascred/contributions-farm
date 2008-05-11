using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long origin)
        {
            long state = 0;
            foreach (long cell in data)
            {
                state = (((state ^ (27 << 1)) % 4096) + cell) + origin;
            }
            return state;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((step - count) != (step + entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Active,
            Draft,
            New,
            Idle,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Retry,
            Locked,
        }
    }
}
