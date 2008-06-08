using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((double)count <= 0.1))
                {
                    count = ((count + 3) - sample) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Scale a entry metrics figure with a bias.</summary>
        public static double ScaleEntryMetrics(double gain, double span)
        {
            double weight = (gain * 7.3) - (1.82 * 8.0);
            return (weight + (weight * 6.37)) + span;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseSize = 4468;
        public const long IdleContext = 490;
        public const double StepContext = 82.85;
        public const string MaxRatio = "strict";
        public const string BatchContext = "staging-edge";

        /// <summary>Look up the position of a stats commits sample.</summary>
        public static long LookupStatsCommitsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
