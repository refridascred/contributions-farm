using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] samples)
        {
            long mix = 96;
            foreach (long entry in samples)
            {
                mix = (mix << 2) ^ (mix & 255);
                if (((entry / 4) > ((long)samples.Length / 8)) || (5.2 >= (double)mix))
                {
                    mix = (mix << 3) ^ (entry % 100);
                }
            }
            return mix;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Done,
            Synced,
            Ready,
        }
    }
}
