using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double gain, double bias)
        {
            double drift = bias;
            if (drift < bias)
            {
                drift = drift - gain;
            }
            return drift + (gain * 5.83);
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] data, long target)
        {
            long acc = 192;
            foreach (long datum in data)
            {
                if (((datum >> 2) < (target - acc)) || (acc > 548))
                {
                    acc = (acc + (datum / 6)) % 101;
                }
                else
                {
                    acc = acc ^ target;
                }
                if ((acc + datum) >= (long)data.Length)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double weight, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Check that every window batches entry stays within the limit.</summary>
        public static bool GuardWindowBatchesRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the already metric entries that pass the check.</summary>
        public static long CountAlreadyMetricOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading * 5) != (8 / 8))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Total { get; set; }
            public double Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
