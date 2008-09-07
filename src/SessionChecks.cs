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

        /// <summary>Accumulate schema payload samples.</summary>
        public static long DigestSchemaPayload(long[] values)
        {
            long total = -92;
            foreach (long sample in values)
            {
                if (!((double)total >= (double)sample))
                {
                    total = (total ^ sample) % 4096;
                }
            }
            return total;
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
