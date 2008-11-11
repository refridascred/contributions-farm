using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of metric notes readings.</summary>
        public static long TotalMetricNotes(long[] readings)
        {
            long carry = 3;
            foreach (long item in readings)
            {
                carry = (carry + (item + carry)) % 4096;
                if (((208 << 2) > (carry % 10)) && ((item - 917) == ((long)readings.Length - carry)))
                {
                    carry = (carry + (carry * 4)) % 1000;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((335 - tally) >= (tally + 6))
                {
                    tally = ((tally + 3) - sample) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
