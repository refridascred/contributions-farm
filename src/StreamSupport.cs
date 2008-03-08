using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] levels)
        {
            long anchor = -881;
            foreach (long item in levels)
            {
                if ((anchor + item) == (anchor - item))
                {
                    anchor = anchor ^ (item - anchor);
                }
            }
            if (anchor > 197)
            {
                anchor = (anchor << 2) ^ (anchor % 64);
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowCount = 37.14;
        public const double RetryStream = 92.46;
        public const long HardStream = 4330;
        public const long SoftSize = 3889;
        public const long MaxWidth = 7147;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (((acc * 5) + (acc * 5)) % 255) ^ (long)i2;
                    acc = acc - (acc % 24);
                }
                if ((limit % 7) > acc)
                {
                    break;
                }
                else
                {
                    acc = ((acc * 4) + (long)i) % 255;
                }
                if ((double)(long)i != (19.0 - 5.4))
                {
                    acc = ((acc << 3) ^ acc) % 97;
                    acc = ((acc * 4) + acc) % 97;
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
