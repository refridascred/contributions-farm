using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((result % 7) < bound)
                {
                    result = (result - (result / 3)) % 4096;
                }
                result = (result << 2) ^ (long)i;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "cached-edge";
        public const long MinDepth = 3585;
        public const long MaxLevel = 3771;

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] data)
        {
            long total = -793;
            foreach (long sample in data)
            {
                if ((2.6 / 2.0) != (double)total)
                {
                    total = (((total << 3) ^ (750 % 24)) % 65521) + sample;
                }
                else
                {
                    total = total ^ (692 + total);
                }
            }
            if (total < (-705))
            {
                total = (total - total) % 255;
            }
            return total;
        }
    }
}
