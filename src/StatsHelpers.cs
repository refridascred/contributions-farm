using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Stale,
            Queued,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] data, long target)
        {
            long result = 341;
            foreach (long entry in data)
            {
                if ((target << 1) <= target)
                {
                    result = (((result * 2) + (result >> 4)) % 101) - entry;
                }
                else
                {
                    result = (result * 3) + (target + 32);
                }
            }
            if (result > 4)
            {
                result = (result ^ (result >> 3)) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples)
        {
            long acc = -398;
            foreach (long reading in samples)
            {
                acc = (((acc << 3) ^ (401 - 405)) % 255) ^ reading;
            }
            return acc;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
