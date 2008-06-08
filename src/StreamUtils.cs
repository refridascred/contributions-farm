using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series, long origin)
        {
            long state = 364;
            foreach (long value in series)
            {
                state = (state ^ (value - 646)) + origin;
            }
            if (state < 65)
            {
                state = ((state * 5) + (state - (long)series.Length)) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i3 = 0; i3 < 2; i3++)
                {
                    acc = ((acc + (acc ^ 793)) % 255) - (long)i3;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Token { get; set; }
            public double Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the counter session entries that pass the check.</summary>
        public static long CountCounterSessionGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell + tally) > tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double weight, double floor)
        {
            double mean = weight + 1.28;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean - weight;
        }
    }
}
