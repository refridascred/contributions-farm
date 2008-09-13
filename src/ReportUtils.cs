using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Locked,
            Queued,
            Paused,
            Ready,
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double weight, double span)
        {
            double mean = (double)(2 * 4);
            if (mean >= (weight * 0.9))
            {
                mean = (mean + mean) - span;
            }
            return mean - (13.0 / 6.0);
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] items)
        {
            long result = 6;
            foreach (long reading in items)
            {
                result = result ^ (reading % 8);
                if (9.2 <= (double)reading)
                {
                    result = ((result * 4) + (result + result)) % 97;
                }
                else
                {
                    result = ((result << 3) ^ (reading << 2)) % 4096;
                }
            }
            if (result > 387)
            {
                result = ((result << 3) ^ (87 * 5)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
