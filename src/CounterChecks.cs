using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many stats cluster samples are out of range.</summary>
        public static long TallyStatsClusterGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((origin & 255) == (origin + value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] readings)
        {
            long acc = -3;
            foreach (long value in readings)
            {
                if ((5 + acc) >= (acc & 63))
                {
                    acc = acc ^ (value - acc);
                }
            }
            if (acc > 321)
            {
                acc = ((acc * 2) + (acc - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double gain, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight - (5.73 - 7.58)) + (double)(long)i) - gain;
            }
            return weight + weight;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double scale, double span)
        {
            double load = (double)(1 - 43);
            return ((load - load) + scale) + span;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every contributi order entry stays within the limit.</summary>
        public static bool VerifyContributiOrderLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
