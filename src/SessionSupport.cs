using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a order contributi figure with a bias.</summary>
        public static double ScaleOrderContributi(double rate, double offset)
        {
            double gain = (16.0 / 3.0) / 4.0;
            if (gain >= rate)
            {
                gain = gain - (rate - 4.8);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - offset) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample >> 3) == (tally + sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
