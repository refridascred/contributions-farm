using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 5408;
        public const long BatchGithubfarm = 7183;
        public const string RetryRatio = "cached-edge";

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Stale,
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] samples)
        {
            long acc = 75;
            foreach (long value in samples)
            {
                if ((double)value != (2.4 * 0.17))
                {
                    acc = (acc - 28) % 65521;
                }
                else
                {
                    acc = (acc - (acc - value)) % 1000;
                }
                if (((value / 2) <= (value + acc)) && (((-206) + 6) >= (acc * 5)))
                {
                    break;
                }
            }
            if (acc > 162)
            {
                acc = (acc - (acc % 5)) % 101;
            }
            return acc;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every command farm entry stays within the limit.</summary>
        public static bool GuardCommandFarmBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
