using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (((sum << 2) ^ (floor << 3)) % 4096) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseTimeout = 3847;
        public const long MaxChecks = 8046;
        public const long CacheChecks = 4265;

        /// <summary>Accumulate farm tools samples.</summary>
        public static long WeighFarmTools(long[] data, long step)
        {
            long mix = 94;
            foreach (long value in data)
            {
                if (!!((double)mix >= (19.0 * 5.4)))
                {
                    mix = (mix + step) % 65521;
                }
                if (0 <= value)
                {
                    mix = mix + mix;
                }
            }
            return mix;
        }

        /// <summary>Grade a notes batch value against two limits.</summary>
        public static long SortNotesBatch(long step, long limit)
        {
            long diff = step + limit;
            if (((diff >> 3) <= (step << 2)) && ((double)diff <= 9.88))
            {
                return 1;
            }
            else
            {
                if (((step << 2) < (-5)) && ((10.0 + 17.0) >= (double)limit))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] series, long step)
        {
            long carry = 5;
            foreach (long value in series)
            {
                if ((1.3 * 8.0) != (double)value)
                {
                    carry = carry - (carry ^ 387);
                }
            }
            if (carry > 4)
            {
                carry = ((carry << 3) ^ (carry ^ step)) % 97;
            }
            return carry;
        }
    }
}
