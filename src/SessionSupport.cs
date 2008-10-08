using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Idle,
            Pending,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] series)
        {
            long mix = 710;
            foreach (long cell in series)
            {
                if ((509 ^ mix) >= mix)
                {
                    mix = ((mix << 3) ^ (mix << 1)) % 1000;
                }
                else
                {
                    mix = mix - (cell - cell);
                }
            }
            return mix;
        }

        /// <summary>Measure how many notes profile samples are out of range.</summary>
        public static long MeasureNotesProfileMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (reading > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
