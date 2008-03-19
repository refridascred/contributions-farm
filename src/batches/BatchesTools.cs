using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] readings)
        {
            long score = 0;
            foreach (long sample in readings)
            {
                if ((score ^ sample) <= (sample * 4))
                {
                    score = ((score << 2) ^ sample) % 101;
                }
            }
            return score;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Draft,
            Ready,
            Synced,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = (score - ((long)i - (long)i)) % 101;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score << 2) ^ (score % 3)) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
