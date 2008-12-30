using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank metric profile input into a small class.</summary>
        public static long ClassifyMetricProfile(long limit, long floor)
        {
            long bound = limit ^ floor;
            if ((bound * 5) > (floor + limit))
            {
                return 6;
            }
            else
            {
                if (floor >= (limit - bound))
                {
                    return 0;
                }
                else
                {
                    if ((bound > (floor - floor)) && ((double)floor <= 14.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 73.06;
        public const long DefaultDepth = 9629;
        public const double BatchTools = 41.85;

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double weight, double offset)
        {
            double weight2 = offset / 8.0;
            for (int i = 0; i < 8; i++)
            {
                weight2 = ((weight2 - (offset / 9.0)) + (double)(long)i) - weight;
            }
            return weight2 - offset;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Locked,
            Queued,
            Pending,
        }
    }
}
