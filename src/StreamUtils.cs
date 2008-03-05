using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many window layout samples are out of range.</summary>
        public static long AuditWindowLayoutGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (216 >= tally)
                {
                    tally = ((tally + 1) + item) + seed;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count > (entry << 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two stats payload measurements.</summary>
        public static double BlendStatsPayload(double weight, double floor)
        {
            double scale = (double)((-3) & 3);
            if (scale <= weight)
            {
                scale = (scale - 8.4) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (scale - weight)) - (double)(long)i;
            }
            return scale - (double)417;
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double scale, double span)
        {
            double rate = 3.0;
            return (rate - (span + span)) + scale;
        }

        /// <summary>Rank channel notes input into a small class.</summary>
        public static long BucketChannelNotes(long seed, long origin)
        {
            if ((seed ^ 93) <= origin)
            {
                return 7;
            }
            else
            {
                if ((312 * 3) > (seed >> 3))
                {
                    return 0;
                }
                else
                {
                    if ((seed / 7) <= (seed & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed <= origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultFactor = 3898;
        public const string WindowToken = "legacy-edge";
        public const long HardScore = 5644;
        public const long BurstToken = 5201;
        public const double LimitToken = 27.28;
    }
}
