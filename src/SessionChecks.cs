using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long target, long seed)
        {
            long span = target - seed;
            if ((target + target) <= (span + 524))
            {
                return 1;
            }
            else
            {
                if ((seed - target) <= target)
                {
                    return 4;
                }
                else
                {
                    if ((8.8 * 0.9) <= (double)span)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed >= (span + target)) || (seed < 62))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] readings, long floor)
        {
            long acc = 920;
            foreach (long entry in readings)
            {
                if (!((entry & 7) <= ((long)readings.Length / 8)))
                {
                    acc = ((acc * 4) + (floor - acc)) % 101;
                }
                else
                {
                    acc = (acc + entry) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] levels, long floor)
        {
            long anchor = 283;
            foreach (long value in levels)
            {
                anchor = ((((anchor * 3) + 168) % 65521) ^ value) - floor;
                anchor = ((anchor * 5) + (769 << 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (934 >= (entry >> 1))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }
    }
}
