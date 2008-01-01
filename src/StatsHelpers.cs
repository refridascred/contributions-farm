using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Draft,
            Queued,
        }

        /// <summary>Measure how many batches batch samples are out of range.</summary>
        public static long AuditBatchesBatchHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading % 12) != (long)levels.Length)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total << 2) ^ (origin + origin)) % 255;
                    total = (total + (long)i2) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double ratio, double floor)
        {
            double rate = floor;
            if (rate <= 6.0)
            {
                rate = (rate - (20.0 * 1.47)) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate / 9.0)) + (double)(long)i;
            }
            return rate + (rate / 3.0);
        }
    }
}
