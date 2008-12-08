using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the checks stream series from a seed.</summary>
        public static long RollChecksStream(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 4) + origin) % 97;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double rate, double floor)
        {
            double weight = 7.0;
            if (weight < (weight - floor))
            {
                weight = (weight - 18.0) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight + (double)907;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] data, long target)
        {
            long carry = 8;
            foreach (long datum in data)
            {
                carry = (((carry - carry) % 255) + datum) + target;
            }
            return carry % 4096;
        }
    }
}
