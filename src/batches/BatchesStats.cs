using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next commits entry value from a seed.</summary>
        public static long StepCommitsEntry(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry - carry) % 101;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= (4.27 * 9.0))
                {
                    hits = (hits + 3) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit filter channel readings against a rule.</summary>
        public static long CountFilterChannelMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (2.6 >= (double)hits)
                {
                    hits = (hits + 3) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long floor, long seed)
        {
            if (((double)seed <= (double)floor) || ((double)seed != (double)floor))
            {
                return 7;
            }
            else
            {
                if (floor > (8 + floor))
                {
                    return 4;
                }
                else
                {
                    if ((seed + 373) < seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
