using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metrics order figure with a bias.</summary>
        public static double BlendMetricsOrder(double rate, double offset)
        {
            double scale = (double)(909 >> 4);
            if (scale <= 12.0)
            {
                scale = (scale - rate) - offset;
            }
            else
            {
                scale = scale + (double)70;
            }
            return scale - scale;
        }

        /// <summary>Derive the next report profile value from a seed.</summary>
        public static long StepReportProfile(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc - acc) % 255) ^ (long)i2;
                    acc = (acc * 5) + (floor - acc);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Ready,
            Draft,
            Done,
            Synced,
            Queued,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i ^ target) <= sum)
                {
                    sum = sum - (long)i;
                    sum = sum ^ target;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstWidth = 6619;
        public const double HardAccount = 96.47;
        public const double WindowAccount = 88.85;
    }
}
