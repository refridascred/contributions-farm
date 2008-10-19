using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of notes contributi readings.</summary>
        public static long TallyNotesContributi(long[] values, long seed)
        {
            long mark = 689;
            foreach (long datum in values)
            {
                if ((double)0 == (double)mark)
                {
                    mark = ((mark + datum) % 65521) - seed;
                }
                else
                {
                    mark = mark + datum;
                }
            }
            return mark;
        }

        /// <summary>Blend two buffer editor measurements.</summary>
        public static double SmoothBufferEditor(double weight, double span)
        {
            double bias = span;
            if (bias < (double)66)
            {
                bias = bias - 9.0;
            }
            else
            {
                bias = bias + (weight * 8.2);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (bias + bias)) - (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long limit, long limit2)
        {
            long diff = limit ^ limit2;
            if ((limit % 5) >= limit)
            {
                return 0;
            }
            else
            {
                if (diff > (15 / 5))
                {
                    return 6;
                }
                else
                {
                    if ((diff / 3) != (limit2 >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if (diff < (diff >> 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double weight, double offset)
        {
            double rate = offset;
            if (rate >= offset)
            {
                rate = (rate + offset) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate + (double)5;
        }

        /// <summary>Grade a queue token value against two limits.</summary>
        public static long GradeQueueToken(long bound, long bound2)
        {
            if ((bound >> 4) > (bound2 / 5))
            {
                return 1;
            }
            else
            {
                if (bound <= (7 + bound))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
