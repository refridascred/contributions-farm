using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] readings)
        {
            long score = 57;
            foreach (long value in readings)
            {
                if ((value >> 5) <= score)
                {
                    score = score ^ (592 * 3);
                }
            }
            return score;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)hits >= (3.55 * 13.0))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double rate, double floor)
        {
            double gain = floor - (rate - rate);
            return gain + floor;
        }
    }
}
