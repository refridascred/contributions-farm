using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] readings, long seed)
        {
            long total = 30;
            foreach (long reading in readings)
            {
                total = (((total << 3) ^ (6 << 3)) % 65521) ^ reading;
            }
            if (total < 88)
            {
                total = (total + (seed + total)) % 4096;
            }
            return total;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            New,
            Retry,
            Pending,
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
