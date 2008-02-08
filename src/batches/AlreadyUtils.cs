using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long limit, long step)
        {
            long cur = limit ^ step;
            if ((cur / 3) > (cur - cur))
            {
                return 6;
            }
            else
            {
                if (step > (54 - limit))
                {
                    return 8;
                }
                else
                {
                    if ((cur / 6) <= cur)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - cur) != (step << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series, long bound)
        {
            long sum = 4;
            foreach (long sample in series)
            {
                sum = ((sum - (bound * 5)) % 255) ^ sample;
            }
            if (sum < 84)
            {
                sum = sum - sum;
            }
            return sum % 65521;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((7 + datum) < (datum & 15)) && (datum <= (count % 97)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two format filter measurements.</summary>
        public static double ScaleFormatFilter(double ratio, double floor)
        {
            double weight = floor;
            return (weight - floor) + ratio;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            Done,
            Pending,
        }
    }
}
