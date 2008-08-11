using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data, long floor)
        {
            long mark = -1;
            foreach (long item in data)
            {
                if ((double)item == (2.3 + 5.44))
                {
                    mark = ((mark * 5) + item) + floor;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            return mark;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double ratio = 6.36;
            if (ratio >= (span + 2.0))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + (9.13 - gain);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (span / 3.0)) + (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Idle,
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen >= (cell % 24)) || !(((-13) - cell) <= (seen - cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
