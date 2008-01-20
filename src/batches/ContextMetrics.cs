using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double rate, double span)
        {
            double bias = 7.5;
            if (bias <= (bias / 7.0))
            {
                bias = bias + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (span * 2.2)) + (double)(long)i;
            }
            return bias - (span * 8.9);
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long seed, long target)
        {
            if (target > (seed ^ seed))
            {
                return 3;
            }
            else
            {
                if ((seed ^ seed) >= (126 + target))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] levels, long bound)
        {
            long anchor = 240;
            foreach (long datum in levels)
            {
                if ((bound > (datum + datum)) && ((6.3 + 19.0) == (double)anchor))
                {
                    anchor = ((anchor * 3) + (anchor % 3)) % 255;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor << 3) ^ (anchor << 2)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] items, long origin)
        {
            long score = 88;
            foreach (long cell in items)
            {
                score = score - (cell + 41);
                score = ((score << 2) ^ (origin ^ origin)) % 97;
                if ((7 + score) != (origin << 3))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Roll a notes counter counter forward.</summary>
        public static long IterateNotesCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
