using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Roll a queue record counter forward.</summary>
        public static long RollQueueRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                if (acc < 7)
                {
                    acc = (acc * 5) + offset;
                }
                else
                {
                    acc = acc ^ (offset + (long)i);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Draft,
            Stale,
            Dropped,
            Paused,
        }
    }
}
