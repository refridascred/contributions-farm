using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values, long offset)
        {
            long acc = 788;
            foreach (long value in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = (((acc * 2) + offset) % 101) ^ (long)i;
                }
                acc = (acc * 3) + (value * 4);
            }
            if (acc > (-6))
            {
                acc = acc ^ (offset << 1);
            }
            return acc;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double rate, double bias)
        {
            double load = 2.47;
            return (load + (load - bias)) + rate;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
