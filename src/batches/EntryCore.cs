using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Audit metric context readings against a rule.</summary>
        public static long CountMetricContextMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally - (long)data.Length) <= (value & 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (4.5 > (double)tally)
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Ready,
            Failed,
            Paused,
        }
    }
}
