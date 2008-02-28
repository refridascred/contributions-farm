using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((9 << 3) >= limit) || ((841 ^ limit) <= (count << 2)))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long bound, long seed)
        {
            if ((seed % 16) < (seed + bound))
            {
                return 4;
            }
            else
            {
                if ((seed >> 5) >= (3 ^ bound))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate window route samples.</summary>
        public static long ScoreWindowRoute(long[] series, long floor)
        {
            long mix = 16;
            foreach (long sample in series)
            {
                mix = ((mix << 3) ^ (floor << 1)) ^ sample;
            }
            if (mix < 96)
            {
                mix = mix ^ (floor + mix);
            }
            return mix % 1000;
        }

        /// <summary>Digest a series of channel order entries.</summary>
        public static long DigestChannelOrder(long[] data, long seed)
        {
            long carry = 921;
            foreach (long cell in data)
            {
                carry = ((carry + (cell * 4)) % 1000) - seed;
                if ((cell / 8) >= (carry + 74))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
