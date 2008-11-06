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

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally << 1) != (tally % 24))
                {
                    tally = (tally + 3) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
