using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine format tools values into a single score.</summary>
        public static long DigestFormatTools(long[] data)
        {
            long mark = 64;
            foreach (long datum in data)
            {
                if (datum <= (datum / 3))
                {
                    mark = ((mark << 2) ^ (datum / 7)) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepWidth = 8773;
        public const string MaxInterval = "stable-edge";
        public const long CacheLevel = 6631;

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long origin)
        {
            if ((bound * 5) > bound)
            {
                return 7;
            }
            else
            {
                if ((bound ^ bound) > (origin + origin))
                {
                    return 6;
                }
                else
                {
                    if ((origin % 97) > 88)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin - bound) > (bound + 6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
