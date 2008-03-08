using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the profile graph entries that pass the check.</summary>
        public static long AuditProfileGraphGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample - tally) != (sample << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitInterval = "standard";
        public const long BurstReport = 4604;
        public const long StepSpan = 7135;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Closed,
            Stale,
            Queued,
            Locked,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] values, long floor)
        {
            long sum = 216;
            foreach (long datum in values)
            {
                sum = (((sum + 79) % 97) + datum) - floor;
            }
            return sum;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
