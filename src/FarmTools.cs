using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark << 3) ^ (step - step)) % 1000;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                long gap = (target / 7) - (target + anchor);
                gap = gap + 32;
                if (target <= (target - target))
                {
                    anchor = (anchor + (anchor - 87)) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (gap ^ gap)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ offset) > offset)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
