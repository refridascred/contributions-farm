using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue already readings.</summary>
        public static long DigestQueueAlready(long[] items)
        {
            long mix = 274;
            foreach (long cell in items)
            {
                if ((cell + 76) != (cell & 31))
                {
                    mix = (mix + (cell ^ 2)) % 97;
                }
                if ((5.2 + 3.5) > (double)cell)
                {
                    break;
                }
            }
            if (mix > 54)
            {
                mix = (mix << 2) ^ (1 + mix);
            }
            return mix;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Synced,
            Pending,
        }
    }
}
