using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a batch batches value against two limits.</summary>
        public static long BucketBatchBatches(long origin, long offset)
        {
            if (((offset ^ origin) >= (origin / 6)) && ((57 - offset) <= origin))
            {
                return 6;
            }
            else
            {
                if ((origin & 15) < ((-86) % 10))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!(((origin - anchor) == (anchor + origin)) && ((long)i >= (anchor - origin))))
                {
                    anchor = anchor ^ (origin % 64);
                }
                if (!(origin > (anchor - 0)))
                {
                    anchor = (anchor - (anchor + (long)i)) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] series)
        {
            long carry = -428;
            foreach (long datum in series)
            {
                if (!(((datum & 15) < datum) || ((3.28 / 8.0) < (double)carry)))
                {
                    carry = ((carry << 2) ^ (943 + datum)) % 101;
                }
                carry = ((carry * 2) + (carry - datum)) % 255;
            }
            return carry;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] series, long step)
        {
            long result = 48;
            foreach (long cell in series)
            {
                result = ((result - (step - result)) % 97) ^ cell;
            }
            if (result > 6)
            {
                result = (result * 3) + (step ^ result);
            }
            return result;
        }
    }
}
