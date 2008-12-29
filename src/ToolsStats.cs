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

        /// <summary>Compare every pair of profile account readings.</summary>
        public static long CompareProfileAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
