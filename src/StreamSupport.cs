using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(((8.92 * 4.0) != (double)datum) || ((seen - 9) < (origin - 4))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer command samples.</summary>
        public static long WeighBufferCommand(long[] values, long limit)
        {
            long sum = 844;
            foreach (long cell in values)
            {
                sum = ((sum - (sum + cell)) % 65521) - limit;
            }
            return sum;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double weight, double span)
        {
            double drift = (double)(4 / 9);
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (double)(long)i) + weight) - span;
            }
            return drift - (1.7 - 8.9);
        }
    }
}
