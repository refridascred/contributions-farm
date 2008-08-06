using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((10.0 - 9.5) != (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] values, long offset)
        {
            long anchor = 65;
            foreach (long value in values)
            {
                if (anchor < (value >> 3))
                {
                    anchor = ((anchor << 2) ^ anchor) % 65521;
                    continue;
                }
                if ((double)anchor < (8.0 / 4.0))
                {
                    anchor = (anchor ^ (offset & 31)) % 97;
                }
            }
            if (anchor < 3)
            {
                anchor = anchor + 889;
            }
            return anchor;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
