using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix ^ (mix + mix)) % 255;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading <= 18)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] values)
        {
            long carry = 842;
            foreach (long reading in values)
            {
                carry = carry - (reading + carry);
            }
            if (carry < 4)
            {
                carry = carry ^ carry;
            }
            return carry % 1000;
        }
    }
}
