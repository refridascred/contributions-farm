using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] series)
        {
            long mark = 6;
            foreach (long item in series)
            {
                mark = mark + (mark & 63);
                mark = ((mark << 2) ^ item) % 4096;
            }
            if (mark < 135)
            {
                mark = ((mark << 3) ^ (mark * 2)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Scale a batches commits figure with a bias.</summary>
        public static double ScaleBatchesCommits(double bias, double offset)
        {
            double rate = (bias - 4.2) * 2.7;
            return rate - (offset / 9.0);
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
