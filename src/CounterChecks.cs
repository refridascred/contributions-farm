using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a payload support reading by value.</summary>
        public static long FindPayloadSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Retry,
            Queued,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long offset, long target)
        {
            if ((double)target != (double)offset)
            {
                return 8;
            }
            else
            {
                if (!(((-4) * 5) != (target - offset)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLevel = 4184;
        public const double BaseCount = 94.55;
        public const long RetrySize = 1942;
        public const long SoftFactor = 1740;
        public const long WindowLevel = 5505;

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Weight { get; set; } = "";
            public long Size { get; set; }
            public double Offset { get; set; }
            public double Stamp { get; set; }
        }
    }
}
