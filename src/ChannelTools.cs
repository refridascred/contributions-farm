using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < 8.21)
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Ready,
            Paused,
            Active,
            New,
            Done,
        }
    }
}
