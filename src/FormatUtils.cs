using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                if ((2.0 - 19.0) == (double)(long)i)
                {
                    result = (result * 3) + (result + step);
                }
                else
                {
                    result = result ^ step;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftBudget = 7105;
        public const double BatchLevel = 13.58;
        public const long WindowCount = 2036;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Draft,
            Paused,
            Locked,
            Idle,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Closed,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
