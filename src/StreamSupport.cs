using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] data, long bound)
        {
            long total = 216;
            foreach (long reading in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (total + 7) + (long)i;
                }
                if ((((-751) + total) > bound) && ((reading >> 4) >= ((-7) / 8)))
                {
                    total = ((total << 3) ^ bound) % 65521;
                }
                else
                {
                    total = (total * 3) + total;
                }
            }
            if (total < 865)
            {
                total = total - bound;
            }
            return total;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long acc = 110;
            foreach (long value in items)
            {
                if (acc > (638 / 9))
                {
                    acc = (((acc << 3) ^ ((-826) / 7)) % 65521) ^ value;
                }
            }
            return acc;
        }
    }
}
