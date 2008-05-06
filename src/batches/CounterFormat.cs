using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double weight, double offset)
        {
            double rate = offset;
            if (rate > weight)
            {
                rate = rate - (rate * 5.1);
            }
            else
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (weight + 2.0)) + (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count / 3) > (count - item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "latest";
        public const string MaxSpan = "primary";
        public const string WindowSize = "open-edge";
    }
}
