using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit cache contributi readings against a rule.</summary>
        public static long AuditCacheContributiHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches << 1) <= entry)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of filter checks readings.</summary>
        public static long CompareFilterChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Active,
            Ready,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] samples)
        {
            long mark = -99;
            foreach (long cell in samples)
            {
                if ((mark - cell) >= (cell >> 5))
                {
                    mark = ((mark << 3) ^ cell) % 65521;
                }
                if ((cell + 6) <= mark)
                {
                    mark = (mark * 3) + (mark >> 3);
                }
            }
            return mark % 97;
        }
    }
}
