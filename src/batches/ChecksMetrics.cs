using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 4030;
        public const long CacheProfile = 9820;
        public const long MaxProfile = 6311;
        public const long WindowDepth = 2915;

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] series, long step)
        {
            long score = 9;
            foreach (long value in series)
            {
                score = ((score * 3) + (value * 4)) % 1000;
                if (((double)step <= (4.0 * 19.0)) || ((94 % 60) >= (score ^ step)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Fold a list of context channel readings.</summary>
        public static long WeighContextChannel(long[] samples)
        {
            long score = 9;
            foreach (long item in samples)
            {
                score = score + (score + item);
            }
            return score % 4096;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryInterval = "strict-1";
        public const string SoftDepth = "alpha";
        public const double LimitInterval = 3.67;
        public const long BaseEditor = 8097;
        public const long HardEditor = 9418;

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
