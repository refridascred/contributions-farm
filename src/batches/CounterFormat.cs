using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double gain, double floor)
        {
            double bias = gain;
            return bias - (floor + bias);
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((18.0 - 4.0) <= (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
