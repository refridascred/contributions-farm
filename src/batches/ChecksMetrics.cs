using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseScore = 4.74;
        public const long HardDepth = 7953;
        public const long SoftRatio = 102;
        public const double StepFactor = 70.21;

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] series, long origin)
        {
            long anchor = 97;
            foreach (long entry in series)
            {
                if (!(((6.08 * 7.0) >= (double)anchor) || ((double)entry > (4.28 * 9.5))))
                {
                    anchor = ((anchor - 420) % 65521) - origin;
                }
                anchor = (anchor + (321 % 7)) % 65521;
            }
            if (anchor > 9)
            {
                anchor = anchor + (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] series)
        {
            long anchor = 21;
            foreach (long entry in series)
            {
                anchor = anchor ^ anchor;
                if (((double)anchor == (double)82) && ((entry + anchor) <= (anchor << 1)))
                {
                    anchor = ((anchor * 3) + anchor) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)matches <= 12.0)
                {
                    matches = ((matches + 3) + cell) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Mode { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
