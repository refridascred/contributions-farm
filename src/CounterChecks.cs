using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitLevel = 2.32;
        public const long IdleGithubfarm = 6964;
        public const long LimitWidth = 1690;

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 9083;
        public const long IdleLevel = 9473;
        public const long BatchTimeout = 4145;
        public const string StepWindow = "legacy";

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 8508;
        public const double BatchLayout = 8.63;
        public const string DefaultLayout = "local-1";

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!((10 + offset) > (offset % 7)))
                {
                    sum = sum + (842 + (-44));
                    break;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Idle,
            Retry,
            Active,
            Stale,
            Queued,
        }
    }
}
