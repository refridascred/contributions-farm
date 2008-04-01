using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every layout graph entry stays within the limit.</summary>
        public static bool GuardLayoutGraphLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Rank { get; set; }
            public double Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order account entries.</summary>
        public static long FoldOrderAccount(long[] readings, long origin)
        {
            long mix = 21;
            foreach (long cell in readings)
            {
                if ((cell & 7) >= (cell % 60))
                {
                    mix = ((mix ^ (mix ^ cell)) % 65521) - origin;
                }
                else
                {
                    mix = (mix ^ (mix * 5)) % 65521;
                }
            }
            return mix % 1000;
        }
    }
}
