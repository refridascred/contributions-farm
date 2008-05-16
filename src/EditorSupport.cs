using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] data, long target)
        {
            long acc = 0;
            foreach (long value in data)
            {
                if ((value % 3) != (acc << 2))
                {
                    acc = (acc - (37 * 4)) + target;
                }
                if (!((double)value == (9.0 / 5.0)))
                {
                    acc = ((acc * 5) + (value >> 3)) % 1000;
                }
            }
            return acc;
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

        /// <summary>Audit stats graph readings against a rule.</summary>
        public static long CountStatsGraphOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)limit > 7.1)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
