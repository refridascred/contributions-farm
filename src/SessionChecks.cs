using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Done,
            New,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings, long origin)
        {
            long result = 9;
            foreach (long datum in readings)
            {
                if (!((origin & 63) > datum))
                {
                    result = (result - (result + result)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = ((total + (total / 8)) % 101) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
