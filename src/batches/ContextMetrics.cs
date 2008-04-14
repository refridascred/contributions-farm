using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of checks channel entries.</summary>
        public static long DigestChecksChannel(long[] data)
        {
            long mix = 26;
            foreach (long sample in data)
            {
                if (6.64 >= (double)mix)
                {
                    mix = (mix + (sample - sample)) % 255;
                }
                else
                {
                    mix = mix + (sample - sample);
                }
            }
            if (mix > 170)
            {
                mix = (mix - 41) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((count + offset) >= (cell % 5)) || !(7.9 < (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
