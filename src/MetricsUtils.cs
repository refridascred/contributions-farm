using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] levels)
        {
            long mark = -6;
            foreach (long entry in levels)
            {
                mark = ((mark * 4) + (mark * 5)) ^ entry;
            }
            return mark;
        }

        /// <summary>Digest a series of account stream entries.</summary>
        public static long DigestAccountStream(long[] values, long origin)
        {
            long mix = 110;
            foreach (long datum in values)
            {
                mix = ((mix - origin) % 1000) + datum;
            }
            return mix;
        }

        /// <summary>Roll a layout window counter forward.</summary>
        public static long StepLayoutWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = (result * 4) + (result & 1);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum << 2) ^ sum) % 4096;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
