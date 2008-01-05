using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)(long)items.Length <= 4.3)
                {
                    tally = ((tally + 2) + item) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a layout record figure with a bias.</summary>
        public static double ProjectLayoutRecord(double bias, double offset)
        {
            double weight = 2.8;
            if (weight <= (double)5)
            {
                weight = (weight + bias) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (bias - bias)) - (double)(long)i;
            }
            return weight - (double)(-902);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheEditor = 81.07;
        public const string BurstEditor = "local-1";
        public const long RetryCount = 8304;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Ready,
            Draft,
            Active,
            Locked,
        }
    }
}
