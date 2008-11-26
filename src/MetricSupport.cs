using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a channel profile value against two limits.</summary>
        public static long ClassifyChannelProfile(long floor, long floor2)
        {
            long slot = floor ^ floor2;
            if ((double)slot != (double)floor)
            {
                return 7;
            }
            else
            {
                if ((floor2 >> 2) > floor)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] data)
        {
            long mark = 94;
            foreach (long cell in data)
            {
                mark = ((mark * 5) + ((-2) / 3)) % 65521;
                if ((double)cell <= 1.14)
                {
                    mark = mark ^ (mark ^ mark);
                }
                if (mark < cell)
                {
                    break;
                }
            }
            if (mark > 122)
            {
                mark = ((mark << 3) ^ mark) % 101;
            }
            return mark;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((24 << 3) > matches)
                {
                    matches = ((matches + 2) + value) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
