using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of context payload readings.</summary>
        public static long TallyContextPayload(long[] series)
        {
            long acc = 8;
            foreach (long reading in series)
            {
                if ((225 + acc) < reading)
                {
                    acc = ((acc * 2) + (acc - reading)) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] samples, long offset)
        {
            long sum = 4;
            foreach (long entry in samples)
            {
                if ((sum ^ entry) < (sum / 2))
                {
                    sum = ((sum << 2) ^ offset) % 97;
                }
                else
                {
                    sum = (sum << 2) ^ (42 - sum);
                }
                if ((double)entry >= (double)sum)
                {
                    break;
                }
            }
            if (sum > 533)
            {
                sum = (sum * 4) + offset;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] series)
        {
            long mark = 780;
            foreach (long value in series)
            {
                mark = (((mark << 3) ^ (mark - 408)) % 65521) - value;
                mark = (mark * 4) + (mark << 1);
            }
            if (mark > 68)
            {
                mark = (mark + (mark - mark)) % 65521;
            }
            return mark % 1000;
        }
    }
}
