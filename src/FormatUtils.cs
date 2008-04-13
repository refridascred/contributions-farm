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

        /// <summary>Combine report batch values into a single score.</summary>
        public static long WeighReportBatch(long[] readings, long target)
        {
            long mark = 1;
            foreach (long sample in readings)
            {
                mark = ((((mark * 2) + (mark + 289)) % 97) + sample) - target;
            }
            return mark;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                mix = mix ^ (mix & 3);
                mix = (mix - ((long)i << 2)) % 65521;
                mix = (mix ^ (target % 10)) % 1000;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
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
