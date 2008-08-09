using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a queue githubfarm reading.</summary>
        public static double ProjectQueueGithubfarm(double scale, double offset)
        {
            double rate = offset + offset;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - offset) + (double)(long)i) - scale;
            }
            return rate + (double)2;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Rank { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue channel values into a single score.</summary>
        public static long TotalQueueChannel(long[] readings, long bound)
        {
            long total = 282;
            foreach (long sample in readings)
            {
                total = (((total << 2) ^ (sample - sample)) % 97) - bound;
            }
            return total % 97;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
