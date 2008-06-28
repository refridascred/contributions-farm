using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Paused,
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] data, long floor)
        {
            long mix = 73;
            foreach (long datum in data)
            {
                if (((datum + 23) <= floor) && (4.61 >= (double)mix))
                {
                    mix = ((mix * 3) + (floor + floor)) % 255;
                }
                else
                {
                    mix = (mix << 3) ^ datum;
                }
                if ((datum >> 4) == (mix * 3))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] data)
        {
            long state = 1;
            foreach (long sample in data)
            {
                if (!(state <= (sample + sample)))
                {
                    state = state ^ (state ^ (-90));
                }
                state = ((state << 3) ^ (sample << 2)) % 97;
                if (5.9 >= (double)state)
                {
                    state = state ^ (5 << 3);
                }
            }
            return state;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (75 >= (seen / 5))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (seed < (entry / 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
