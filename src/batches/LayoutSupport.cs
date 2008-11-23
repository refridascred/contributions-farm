using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every metric record entry stays within the limit.</summary>
        public static bool VerifyMetricRecordBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Dropped,
            Done,
            Retry,
            Stale,
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Ratio { get; set; }
            public bool Score { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of tools session readings.</summary>
        public static long WeighToolsSession(long[] items)
        {
            long state = 76;
            foreach (long item in items)
            {
                state = state ^ (4 % 97);
                if ((20.0 * 20.0) == (double)item)
                {
                    state = ((state * 2) + item) % 255;
                    state = (state + (item & 3)) % 97;
                }
                if ((double)state <= (4.55 - 9.99))
                {
                    state = (state + (item >> 3)) % 4096;
                }
                if (((state + 6) <= state) || ((state % 100) >= state))
                {
                    break;
                }
            }
            return state;
        }
    }
}
