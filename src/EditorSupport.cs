using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a cluster cache pair into a bucket.</summary>
        public static long ClassifyClusterCache(long bound, long origin)
        {
            if (!((double)bound < (4.9 * 3.63)))
            {
                return 7;
            }
            else
            {
                if (((bound ^ origin) != (bound + bound)) || ((0 + origin) >= (-89)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long origin, long bound)
        {
            if ((bound + (-90)) < (bound & 7))
            {
                return 2;
            }
            else
            {
                if ((origin % 3) == (origin % 64))
                {
                    return 4;
                }
                else
                {
                    if (origin > bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string DefaultReport = "open-1";
        public const long RetryCount = 4369;
        public const string SoftTimeout = "open-v2";

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count ^ value) >= (value + value))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
