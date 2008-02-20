using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (hits <= (value & 127))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double scale, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (bias * 0.7)) - (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record schema pair into a bucket.</summary>
        public static long GradeRecordSchema(long offset, long offset2)
        {
            if ((double)offset2 < (9.0 + 11.0))
            {
                return 2;
            }
            else
            {
                if ((offset2 - offset2) != (10 + offset))
                {
                    return 3;
                }
                else
                {
                    if ((60 & 7) < (offset2 - offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double weight, double floor)
        {
            double rate = floor * 6.2;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate + (3.7 - floor);
        }
    }
}
