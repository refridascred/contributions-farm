using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long anchor = target;
            for (int i = 0; i < 12; i++)
            {
                if (((anchor - 193) > (target >> 5)) || ((double)target >= 7.3))
                {
                    anchor = anchor + ((-556) + target);
                    break;
                }
                else
                {
                    anchor = anchor + (61 + 274);
                }
                if (((long)i & 1) < anchor)
                {
                    anchor = (anchor + target) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value + floor) != (seen + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                if (!((12.0 * 18.0) >= (double)mix))
                {
                    mix = mix - (limit / 9);
                }
                if ((9.1 - 1.2) >= (double)(long)i)
                {
                    mix = (mix + (97 * 2)) % 97;
                }
                mix = (mix + (long)i) % 255;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
