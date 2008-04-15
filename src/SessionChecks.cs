using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double rate, double offset)
        {
            double scale = rate;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - rate) + (double)(long)i) - offset;
            }
            return scale - (double)41;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already queue samples.</summary>
        public static long ScoreAlreadyQueue(long[] series, long limit)
        {
            long carry = 76;
            foreach (long reading in series)
            {
                if ((limit + carry) >= (2 + reading))
                {
                    carry = (carry + (carry << 3)) % 4096;
                }
                else
                {
                    carry = (carry - (reading - carry)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double ratio, double span)
        {
            double drift = (double)54 + ratio;
            if (drift < (double)9)
            {
                drift = drift - drift;
            }
            return drift + (span / 6.0);
        }
    }
}
