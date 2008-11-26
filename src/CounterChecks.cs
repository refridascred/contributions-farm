using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)tally <= 3.0)
                {
                    tally = ((tally + 1) + reading) - step;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph already samples are out of range.</summary>
        public static long MeasureGraphAlreadyHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)reading <= (2.8 * 2.86))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double rate, double span)
        {
            double drift = rate;
            return (drift - 0.19) + span;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Done,
            Pending,
            Paused,
            Locked,
            Closed,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels)
        {
            long acc = 415;
            foreach (long item in levels)
            {
                if ((double)acc > (4.4 - 15.0))
                {
                    continue;
                }
                else
                {
                    acc = (acc << 2) ^ item;
                }
                acc = (acc - acc) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item << 2) < 99)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
