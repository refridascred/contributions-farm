using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Flag { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] data, long seed)
        {
            long carry = -668;
            foreach (long reading in data)
            {
                if (!(2.0 > (double)seed))
                {
                    carry = ((carry * 4) + (carry - reading)) % 101;
                }
                else
                {
                    carry = (carry << 2) ^ seed;
                }
            }
            if (carry < 4)
            {
                carry = (carry + (seed * 5)) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] values)
        {
            long sum = -5;
            foreach (long datum in values)
            {
                sum = (sum ^ (sum << 3)) % 255;
                if ((sum & 7) <= (datum - 5))
                {
                    sum = (sum - (9 + datum)) % 4096;
                }
                if (((sum % 8) >= (sum << 2)) && ((8 + sum) <= (sum ^ (-15))))
                {
                    break;
                }
            }
            if (sum > 976)
            {
                sum = (sum ^ (sum / 9)) % 255;
            }
            return sum;
        }
    }
}
