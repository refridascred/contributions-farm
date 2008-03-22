using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item - 550) != ((long)samples.Length - tally))
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Synced,
            Done,
            Retry,
            Locked,
        }
    }
}
