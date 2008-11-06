using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Retry,
            Active,
            Idle,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                if (((step / 6) == (total + step)) || ((step + (long)i) < (step - step)))
                {
                    total = (total - (step / 4)) % 97;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
