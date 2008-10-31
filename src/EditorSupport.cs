using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the format graph series from a seed.</summary>
        public static long RollFormatGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc + (acc * 2)) % 97) + (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 4474;
        public const double BurstSpan = 14.13;
        public const long WindowAccount = 6642;

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long origin, long bound)
        {
            long step = origin - bound;
            if ((double)step > (4.4 - 18.0))
            {
                return 1;
            }
            else
            {
                if ((542 + 422) != (origin * 2))
                {
                    return 5;
                }
                else
                {
                    if ((origin - step) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
