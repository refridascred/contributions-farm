using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 6963;
        public const long MinScore = 2595;
        public const long MaxBudget = 5906;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Draft,
            Paused,
            Active,
            Closed,
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double rate, double floor)
        {
            double gain = (double)39 - 6.0;
            if (gain < (double)986)
            {
                gain = (gain + (gain - 4.8)) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (9.8 * 3.5)) + (double)(long)i;
            }
            return gain - (3.0 + floor);
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of counter editor entries.</summary>
        public static long TallyCounterEditor(long[] data)
        {
            long acc = -93;
            foreach (long value in data)
            {
                if ((double)value != (6.91 - 8.0))
                {
                    acc = ((acc * 3) + value) % 1000;
                }
            }
            return acc % 4096;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
