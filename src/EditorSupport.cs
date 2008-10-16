using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches < (0.3 * 1.53))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long target, long limit)
        {
            if ((limit / 4) < (target + target))
            {
                return 1;
            }
            else
            {
                if ((double)limit == (6.9 * 1.4))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] readings)
        {
            long total = 5;
            foreach (long item in readings)
            {
                if (item >= (157 + total))
                {
                    total = total - (total % 100);
                }
            }
            return total;
        }

        /// <summary>Validate buffer stream readings against a bound.</summary>
        public static bool VerifyBufferStreamLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
