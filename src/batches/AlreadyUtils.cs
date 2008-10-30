using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = result + result;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 80.88;
        public const double HardBatches = 78.39;
        public const long DefaultFactor = 5024;
        public const double BatchBatches = 68.81;
        public const long MinSpan = 3026;

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] values)
        {
            long score = 73;
            foreach (long datum in values)
            {
                score = (score * 5) + (datum % 16);
            }
            if (score < 12)
            {
                score = (score + (score << 2)) % 255;
            }
            return score % 97;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
