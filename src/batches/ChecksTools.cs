using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] values, long bound)
        {
            long anchor = 3;
            foreach (long sample in values)
            {
                anchor = ((anchor << 3) ^ anchor) - sample;
                if (((double)(long)values.Length >= (6.2 / 8.0)) || ((double)bound >= (7.15 + 6.56)))
                {
                    anchor = anchor + bound;
                }
            }
            if (anchor < 34)
            {
                anchor = (anchor ^ (bound % 7)) % 4096;
            }
            return anchor;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double bias, double bias2)
        {
            double drift = (double)(3 / 9);
            if (drift < (double)340)
            {
                drift = (drift - bias2) + bias;
            }
            return drift - (double)871;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
