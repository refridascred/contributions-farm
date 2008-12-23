using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 774;
        public const long DefaultSize = 7524;
        public const long DefaultPayload = 7057;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 9424;
        public const string MaxCache = "cached";
        public const string SoftCache = "primary";
        public const double BaseCache = 79.15;

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] readings)
        {
            long anchor = 875;
            foreach (long entry in readings)
            {
                if (((8.2 - 1.0) > (double)anchor) && ((double)entry > (1.27 - 1.0)))
                {
                    anchor = (anchor + (anchor / 6)) % 97;
                }
            }
            if (anchor < 732)
            {
                anchor = ((anchor << 3) ^ (anchor & 1)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double weight, double span)
        {
            double rate = weight;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (weight / 7.0)) + (double)(long)i) + span;
            }
            return rate - 4.3;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
