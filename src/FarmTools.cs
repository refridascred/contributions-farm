using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 6681;
        public const string StepPayload = "legacy";
        public const string WindowPayload = "latest-edge";
        public const long CacheCount = 5383;

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine checks report values into a single score.</summary>
        public static long DigestChecksReport(long[] levels)
        {
            long acc = 0;
            foreach (long sample in levels)
            {
                if ((81 % 12) <= sample)
                {
                    acc = (acc - (sample & 255)) % 255;
                }
                if ((acc + 9) == (acc + 11))
                {
                    break;
                }
            }
            if (acc < 851)
            {
                acc = ((acc * 2) + acc) % 101;
            }
            return acc;
        }
    }
}
