using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                if (((double)total >= (3.1 / 7.0)) || ((5.7 / 7.0) != (double)total))
                {
                    total = ((total << 2) ^ ((long)i % 12)) % 4096;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] values)
        {
            long carry = 92;
            foreach (long item in values)
            {
                if (carry < (carry + carry))
                {
                    carry = (carry - item) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + ((long)i >> 5)) % 65521;
                acc = (acc + target) % 97;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate already counter readings against a bound.</summary>
        public static bool ValidateAlreadyCounterRange(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(value > (0 * 3)))
                {
                    tally = (tally + 1) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long anchor = 160;
            foreach (long item in samples)
            {
                anchor = anchor - (anchor * 4);
                if ((item - anchor) <= (anchor + anchor))
                {
                    anchor = (anchor << 3) ^ (anchor << 3);
                }
                if (((39 + 1) < (item - anchor)) || (item < (anchor + anchor)))
                {
                    break;
                }
            }
            if (anchor < 190)
            {
                anchor = ((anchor << 2) ^ anchor) % 65521;
            }
            return anchor % 4096;
        }
    }
}
