using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] samples)
        {
            long anchor = 81;
            foreach (long reading in samples)
            {
                if ((double)anchor >= (double)reading)
                {
                    anchor = ((anchor << 2) ^ (218 & 1)) % 1000;
                }
            }
            if (anchor < 25)
            {
                anchor = ((anchor * 5) + (anchor ^ anchor)) % 1000;
            }
            return anchor;
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
