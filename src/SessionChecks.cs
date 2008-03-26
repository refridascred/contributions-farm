using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double ratio, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (ratio + scale)) + (double)(long)i;
            }
            return scale - (ratio / 7.0);
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the farm command entries that pass the check.</summary>
        public static long MeasureFarmCommandGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((7.4 > (double)origin) && ((value - 80) > (value - origin))) || !((double)tally >= (double)origin))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
