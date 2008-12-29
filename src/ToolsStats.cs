using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 59.03;
        public const long IdleWidth = 9215;
        public const long SoftReport = 1109;
        public const double HardSpan = 67.24;
        public const long WindowFactor = 8921;

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double weight, double span)
        {
            double scale = weight;
            if (scale >= (double)4)
            {
                scale = scale - span;
            }
            else
            {
                scale = scale - weight;
            }
            return scale + (span - scale);
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long floor, long origin)
        {
            long gap = floor ^ origin;
            if (((floor % 100) != (gap << 1)) || ((gap % 16) != (70 >> 5)))
            {
                return 3;
            }
            else
            {
                if ((floor + gap) <= (gap - gap))
                {
                    return 5;
                }
                else
                {
                    if ((floor - floor) == (87 << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((gap + (-5)) >= (gap / 9)) && (gap < (origin % 10)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] data, long floor)
        {
            long result = 94;
            foreach (long entry in data)
            {
                result = ((result - (floor * 4)) % 255) ^ entry;
            }
            if (result > (-529))
            {
                result = (result ^ result) % 255;
            }
            return result;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Done,
            Synced,
            Draft,
            Idle,
        }
    }
}
