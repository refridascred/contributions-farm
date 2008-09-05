using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Retry,
            Idle,
            New,
            Closed,
            Synced,
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (item < (long)readings.Length)
                {
                    seen = (seen + 3) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                long delta = state;
                if (offset <= delta)
                {
                    state = state + delta;
                    delta = (delta ^ (offset << 2)) % 101;
                    break;
                }
                delta = delta + delta;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
