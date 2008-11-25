using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double weight, double floor)
        {
            double ratio = (double)(86 >> 4);
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double ratio, double span)
        {
            double drift = span - span;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + ratio) + (double)(long)i;
            }
            return drift - ratio;
        }

        /// <summary>Classify a counter notes pair into a bucket.</summary>
        public static long GradeCounterNotes(long origin, long limit)
        {
            if ((origin % 5) > (6 - origin))
            {
                return 6;
            }
            else
            {
                if (origin <= (origin << 1))
                {
                    return 4;
                }
                else
                {
                    if ((limit - limit) <= (origin + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((92 << 2) >= (origin - origin)) || ((limit & 127) >= origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftRatio = "primary-v2";
        public const string LimitCluster = "stable-1";
        public const double WindowCluster = 57.9;
        public const double DefaultFactor = 53.17;
    }
}
