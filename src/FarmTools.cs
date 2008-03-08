using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] samples, long target)
        {
            long mark = 219;
            foreach (long value in samples)
            {
                if ((69 / 3) > (mark - target))
                {
                    mark = ((mark * 5) + target) % 4096;
                }
                else
                {
                    mark = (mark + (value & 3)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = acc - (step / 3);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
