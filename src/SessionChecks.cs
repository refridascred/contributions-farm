using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)origin == (double)hits)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] items)
        {
            long mix = 30;
            foreach (long cell in items)
            {
                if ((cell % 97) < (92 * 2))
                {
                    mix = (mix * 4) + cell;
                }
                else
                {
                    mix = (mix ^ (6 >> 5)) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long origin, long step)
        {
            long slot = origin - step;
            if ((7.62 - 5.9) < (double)slot)
            {
                return 1;
            }
            else
            {
                if (((7.1 + 2.1) < (double)step) && ((9.2 + 2.4) != (double)slot))
                {
                    return 0;
                }
                else
                {
                    if ((2.72 / 3.0) != (double)slot)
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin >= (9 * 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Retry,
            Closed,
            Synced,
            Queued,
        }
    }
}
