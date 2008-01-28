using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Retry,
            Closed,
            Pending,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (hits < (sample + 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample << 1) <= sample)
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Count checks farm pairs that satisfy a relation.</summary>
        public static long PairChecksFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
