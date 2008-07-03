using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next layout token value.</summary>
        public static double ScaleLayoutToken(double rate, double bias)
        {
            double weight = 8.44 - bias;
            if (weight <= (rate + bias))
            {
                weight = weight - (double)186;
            }
            return weight - rate;
        }

        /// <summary>Measure how many contributi batch samples are out of range.</summary>
        public static long TallyContributiBatchGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((((double)hits == (4.9 - 5.9)) || ((datum % 3) <= 3)) || (((hits + datum) == (hits / 5)) && ((9.29 / 7.0) != (double)hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Active,
            Failed,
            Closed,
            Synced,
        }
    }
}
