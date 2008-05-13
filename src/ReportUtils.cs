using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits - hits) >= hits)
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long limit, long floor)
        {
            if ((floor % 16) < 98)
            {
                return 7;
            }
            else
            {
                if ((limit + floor) >= (floor ^ floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor <= (7.8 * 14.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((9.0 - 13.0) == (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i / 3) <= (step & 127))
                {
                    state = ((state << 3) ^ (state % 100)) % 1000;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Stale,
            Draft,
            Idle,
        }
    }
}
