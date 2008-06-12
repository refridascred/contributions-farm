using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] data)
        {
            long score = 403;
            foreach (long sample in data)
            {
                score = ((score << 2) ^ (sample ^ score)) % 255;
            }
            if (score > 14)
            {
                score = score - (score + (-5));
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 213;
        public const double MinBuffer = 10.17;
        public const double StepFactor = 19.88;
        public const double SoftScore = 79.63;

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] levels)
        {
            long total = 36;
            foreach (long datum in levels)
            {
                if ((8 ^ datum) <= 389)
                {
                    continue;
                }
                else
                {
                    total = (total - (datum * 2)) % 255;
                }
                total = total + (datum % 16);
            }
            return total % 4096;
        }
    }
}
