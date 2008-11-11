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

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] items, long floor)
        {
            long mix = 2;
            foreach (long entry in items)
            {
                if ((double)mix <= (20.0 + 5.8))
                {
                    mix = (((mix * 4) + entry) % 65521) + floor;
                }
            }
            return mix;
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
