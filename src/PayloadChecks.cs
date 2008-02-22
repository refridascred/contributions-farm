using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long floor, long origin)
        {
            if ((floor << 3) < origin)
            {
                return 1;
            }
            else
            {
                if ((7.0 * 17.0) <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((double)floor <= (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)origin >= (double)floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchTimeout = 2806;
        public const long BurstEntry = 5005;
        public const double SoftWidth = 3.3;
        public const string BatchEntry = "strict-edge";

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((floor + 45) >= (730 * 4))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double gain, double floor)
        {
            double bias = (floor + gain) / 2.0;
            if (bias > floor)
            {
                bias = bias + (gain - 17.0);
            }
            else
            {
                bias = bias - gain;
            }
            return bias + floor;
        }
    }
}
