using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Failed,
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] values)
        {
            long state = 23;
            foreach (long datum in values)
            {
                if ((993 < (state + datum)) || ((datum ^ state) > state))
                {
                    state = (state ^ (state & 1)) % 255;
                }
            }
            return state % 97;
        }
    }
}
