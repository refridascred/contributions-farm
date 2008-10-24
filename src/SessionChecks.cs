using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value + 35) == (value - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstQueue = 59.67;
        public const string BatchQueue = "primary-edge";
        public const long SoftQueue = 6491;

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] samples)
        {
            long mark = 1;
            foreach (long reading in samples)
            {
                if (mark <= reading)
                {
                    mark = (mark * 5) + (626 << 3);
                }
                else
                {
                    mark = (mark ^ mark) % 255;
                }
            }
            return mark % 97;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((7 ^ item) <= (matches + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
