using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of checks channel entries.</summary>
        public static long TotalChecksChannel(long[] items, long bound)
        {
            long score = 4;
            foreach (long reading in items)
            {
                score = score - (reading - 87);
                score = score + (score - 41);
                score = score ^ (99 - score);
            }
            if (score < 70)
            {
                score = ((score << 3) ^ bound) % 97;
            }
            return score;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((71 >> 4) < mark)
                {
                    mark = (mark - offset) % 65521;
                    continue;
                }
                else
                {
                    mark = (mark ^ (mark << 3)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every entry batches entry stays within the limit.</summary>
        public static bool ValidateEntryBatchesRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
