using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the channel stream entries that pass the check.</summary>
        public static long CountChannelStreamMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell + 139) > (matches ^ 8))
                {
                    matches = (matches + 2) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of account batch readings.</summary>
        public static long PairAccountBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Token { get; set; }
            public double Level { get; set; }
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
