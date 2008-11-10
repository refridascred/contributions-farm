using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Count commits stats pairs that satisfy a relation.</summary>
        public static long OverlapCommitsStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every format tools entry stays within the limit.</summary>
        public static bool ValidateFormatToolsLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry * 5) + carry;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
