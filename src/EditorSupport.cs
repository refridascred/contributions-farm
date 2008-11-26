using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long floor, long target)
        {
            long gap = floor + target;
            if ((gap >= (gap % 64)) || ((target ^ floor) < target))
            {
                return 3;
            }
            else
            {
                if ((target + gap) >= (target * 5))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double ratio, double offset)
        {
            double bias = ratio / 5.0;
            if (bias <= (ratio * 7.1))
            {
                bias = (bias + bias) - offset;
            }
            return bias + (double)1;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
