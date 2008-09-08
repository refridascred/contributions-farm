using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Retry,
            Stale,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((sample + tally) >= sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] levels, long offset)
        {
            long acc = -18;
            foreach (long sample in levels)
            {
                if ((sample ^ acc) > (acc ^ 4))
                {
                    acc = (acc ^ (acc % 2)) % 101;
                    break;
                }
                acc = (acc * 4) + offset;
                acc = ((acc << 2) ^ (sample >> 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
