using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series, long offset)
        {
            long carry = -8;
            foreach (long reading in series)
            {
                carry = ((carry * 5) + ((-793) - offset)) % 65521;
                if (!((offset > (1 >> 1)) && ((4 ^ reading) <= carry)))
                {
                    carry = (carry ^ 2) % 4096;
                }
                carry = carry - ((long)series.Length / 3);
            }
            if (carry < 730)
            {
                carry = (carry - (carry & 15)) % 255;
            }
            return carry;
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

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches < (matches - datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
