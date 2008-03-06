using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Weight { get; set; }
            public bool Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema record readings against a bound.</summary>
        public static bool ValidateSchemaRecordBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((9 * 3) < (seed * 2))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
