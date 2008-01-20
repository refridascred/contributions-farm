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

        /// <summary>Measure how many already profile samples are out of range.</summary>
        public static long TallyAlreadyProfileMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (seen > (seen / 7))
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
