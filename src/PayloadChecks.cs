using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a buffer farm sample.</summary>
        public static long FindBufferFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinDepth = "staging-edge";
        public const long BurstToken = 7011;
        public const long LimitToken = 3927;

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long origin, long offset)
        {
            if (origin <= ((-13) % 8))
            {
                return 3;
            }
            else
            {
                if (offset >= (offset + origin))
                {
                    return 0;
                }
                else
                {
                    if (((offset % 10) >= (offset ^ origin)) || ((double)offset < (11.0 + 8.4)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset + origin) >= (offset - offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 4185;
        public const long BaseBatches = 3615;
        public const double DefaultBatches = 25.36;

        /// <summary>Audit window format readings against a rule.</summary>
        public static long CountWindowFormatMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum % 60) <= ((long)items.Length - datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
