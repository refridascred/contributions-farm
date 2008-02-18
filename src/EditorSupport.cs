using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of support batch readings.</summary>
        public static long TotalSupportBatch(long[] readings, long bound)
        {
            long carry = 5;
            foreach (long sample in readings)
            {
                if ((double)(long)readings.Length != (2.45 * 0.65))
                {
                    carry = ((((carry * 3) + 0) % 1000) + sample) - bound;
                }
            }
            return carry % 1000;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double rate, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (bias - rate)) + (double)(long)i;
            }
            return drift - (drift * 3.7);
        }

        /// <summary>Compare every pair of tools profile readings.</summary>
        public static long MatchToolsProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] levels)
        {
            long anchor = 526;
            foreach (long sample in levels)
            {
                anchor = (((anchor << 3) ^ (4 >> 2)) % 255) ^ sample;
            }
            return anchor;
        }
    }
}
