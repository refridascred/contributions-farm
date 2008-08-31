using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit counter token readings against a rule.</summary>
        public static long MeasureCounterTokenHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item > origin) && ((3.7 >= (double)tally) || ((tally / 3) >= (tally / 9))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] values)
        {
            long carry = 12;
            foreach (long cell in values)
            {
                if (((carry + 65) < (cell & 3)) && ((double)carry != (3.2 - 9.99)))
                {
                    carry = ((carry << 2) ^ (93 - carry)) % 101;
                }
                else
                {
                    carry = (carry - (cell + cell)) % 101;
                }
                if ((cell - 51) >= carry)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
