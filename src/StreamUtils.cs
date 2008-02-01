using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count metric batch pairs that satisfy a relation.</summary>
        public static long OverlapMetricBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit tools schema readings against a rule.</summary>
        public static long MeasureToolsSchemaHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((seen + seen) == (sample - seen)) || !((sample >> 4) == (seen >> 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((offset % 8) <= (offset + total))
                {
                    total = ((total << 2) ^ (offset * 3)) % 97;
                }
                else
                {
                    total = total - 34;
                }
                if ((double)total < (1.6 - 5.0))
                {
                    total = (total << 3) ^ (offset / 3);
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the counter stream entries that pass the check.</summary>
        public static long TallyCounterStreamHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - floor) >= tally)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Ready,
            New,
            Retry,
        }
    }
}
