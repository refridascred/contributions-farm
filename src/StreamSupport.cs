using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] items, long floor)
        {
            long carry = 3;
            foreach (long sample in items)
            {
                if (!(((double)carry < (2.0 - 9.3)) && ((floor + 23) >= carry)))
                {
                    carry = ((carry ^ (floor + 9)) % 65521) + sample;
                }
                if (carry <= (floor / 4))
                {
                    carry = ((carry << 3) ^ ((-758) + carry)) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum - datum) > (datum + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
