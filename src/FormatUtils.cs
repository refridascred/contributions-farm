using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine account command values into a single score.</summary>
        public static long DigestAccountCommand(long[] values)
        {
            long mix = 6;
            foreach (long sample in values)
            {
                mix = (mix - (mix % 60)) ^ sample;
                mix = ((mix << 2) ^ (934 + mix)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Active,
            Closed,
            Ready,
            Paused,
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
