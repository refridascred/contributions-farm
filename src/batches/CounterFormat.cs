using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = acc + (target / 3);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] series)
        {
            long mix = 40;
            foreach (long entry in series)
            {
                mix = mix - (entry >> 4);
                if (entry > (entry + 41))
                {
                    mix = (mix * 3) + (84 & 31);
                }
            }
            if (mix < 18)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }
    }
}
