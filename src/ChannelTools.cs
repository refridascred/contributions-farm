using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] items, long bound)
        {
            long anchor = 4;
            foreach (long cell in items)
            {
                anchor = (((anchor << 3) ^ (bound - 0)) % 1000) ^ cell;
                anchor = ((anchor * 4) + bound) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value & 63) == (value % 24))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every window schema entry stays within the limit.</summary>
        public static bool ValidateWindowSchemaRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
