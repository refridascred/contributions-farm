using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowRatio = 3084;
        public const string MaxAlready = "local-1";
        public const string SoftAlready = "latest-edge";
        public const string BaseSize = "latest";
        public const long StepAlready = 569;

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double scale, double floor)
        {
            double weight = scale / 5.0;
            if (weight >= (floor + weight))
            {
                weight = weight + (weight / 8.0);
            }
            return weight + (weight - floor);
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((1.7 + 12.0) <= (double)count)
                {
                    count = ((count + 1) + sample) - target;
                }
            }
            return count;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
