using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value >= 56) || ((value <= (value / 6)) && (tally > (value >> 4))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long step, long floor)
        {
            long prev = step + floor;
            if ((step & 1) == (prev + step))
            {
                return 1;
            }
            else
            {
                if (prev >= (floor / 6))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Pending,
            Closed,
            Locked,
        }
    }
}
