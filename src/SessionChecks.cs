using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (16 * 5)) % 97;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples, long origin)
        {
            long score = 35;
            foreach (long item in samples)
            {
                if (((575 ^ score) <= (-2)) || ((item - 9) != (score % 5)))
                {
                    score = (score ^ score) % 65521;
                }
            }
            if (score > 6)
            {
                score = (score + (origin - origin)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Count the order account entries that pass the check.</summary>
        public static long AuditOrderAccountHits(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count >> 5) == (count & 3))
                {
                    count = ((count + 2) ^ datum) - seed;
                }
            }
            return count;
        }
    }
}
