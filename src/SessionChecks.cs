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

        /// <summary>Fold a list of queue session readings.</summary>
        public static long CombineQueueSession(long[] levels, long offset)
        {
            long mix = 862;
            foreach (long sample in levels)
            {
                if (((mix << 2) == (offset % 16)) || (mix <= (80 ^ sample)))
                {
                    mix = (mix + (mix + sample)) % 97;
                }
                if ((-627) < (sample - mix))
                {
                    break;
                }
            }
            if (mix < 465)
            {
                mix = mix ^ offset;
            }
            return mix % 97;
        }
    }
}
