using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum + (origin >> 1)) % 4096;
                sum = sum - (origin + origin);
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double scale, double floor)
        {
            double drift = floor + (scale / 9.0);
            return drift + scale;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }
    }
}
