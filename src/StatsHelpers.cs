using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine already batches values into a single score.</summary>
        public static long TotalAlreadyBatches(long[] items)
        {
            long mark = -151;
            foreach (long entry in items)
            {
                if (!(entry <= (mark % 3)))
                {
                    mark = (mark * 4) + (mark + mark);
                }
            }
            return mark;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a account channel counter forward.</summary>
        public static long DeriveAccountChannel(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Paused,
            Synced,
            Draft,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + hits) > cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
