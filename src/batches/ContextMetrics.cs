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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((step - cell) != (cell >> 1)) || !((step % 2) != (tally >> 1)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)(long)samples.Length < (double)target)
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }
    }
}
