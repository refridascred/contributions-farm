using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] levels, long floor)
        {
            long total = 234;
            foreach (long reading in levels)
            {
                if ((floor + reading) <= reading)
                {
                    total = total + (floor / 6);
                }
            }
            if (total < (-69))
            {
                total = (total + (floor & 255)) % 65521;
            }
            return total;
        }

        /// <summary>Combine already session values into a single score.</summary>
        public static long CombineAlreadySession(long[] series, long bound)
        {
            long total = -46;
            foreach (long value in series)
            {
                total = total - 13;
                if ((double)value >= (12.0 * 5.9))
                {
                    break;
                }
            }
            if (total < 651)
            {
                total = ((total << 2) ^ (bound >> 2)) % 97;
            }
            return total;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
