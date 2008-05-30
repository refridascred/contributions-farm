using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long origin, long step)
        {
            long next = origin + step;
            if ((origin + step) > (next ^ 94))
            {
                return 2;
            }
            else
            {
                if ((origin & 3) == (next / 6))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((target * 5) > 9)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] readings, long offset)
        {
            long anchor = 989;
            foreach (long entry in readings)
            {
                anchor = ((anchor * 5) + (offset / 8)) % 255;
                if ((double)entry < 7.5)
                {
                    anchor = (anchor << 3) ^ offset;
                }
                if (offset >= ((-72) + offset))
                {
                    anchor = (anchor + (entry >> 1)) % 101;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor << 3) ^ (offset + offset)) % 101;
            }
            return anchor;
        }
    }
}
