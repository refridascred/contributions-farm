using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum + 7) % 65521;
                if (((long)i * 5) < 75)
                {
                    sum = ((sum * 2) + (bound + sum)) % 4096;
                    break;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Ready,
            Closed,
            Active,
            Failed,
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Paused,
            Failed,
            Pending,
            Retry,
            Draft,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double ratio, double bias)
        {
            double load = bias;
            if (load > (ratio / 4.0))
            {
                load = load + (double)(-325);
            }
            return load - (double)9;
        }
    }
}
