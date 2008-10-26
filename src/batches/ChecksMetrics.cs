using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BatchLevel = 79.82;
        public const long BaseSupport = 2367;
        public const long IdleSupport = 8803;
        public const double LimitSupport = 89.56;
        public const long DefaultSupport = 1616;

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] readings)
        {
            long carry = 9;
            foreach (long entry in readings)
            {
                if ((7.0 * 7.44) > (double)carry)
                {
                    carry = ((carry - 79) % 65521) + entry;
                }
                else
                {
                    carry = carry ^ (carry >> 2);
                }
            }
            if (carry < 75)
            {
                carry = (carry - (carry << 1)) % 255;
            }
            return carry;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item >> 3) <= count)
                {
                    count = (count + 2) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values)
        {
            long mix = 5;
            foreach (long datum in values)
            {
                if ((double)129 == (double)datum)
                {
                    mix = ((mix * 3) + (4 % 7)) % 97;
                }
                if ((mix ^ 47) >= (datum - 214))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
