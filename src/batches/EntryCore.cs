using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long target, long seed)
        {
            if ((double)seed <= (2.35 - 9.75))
            {
                return 8;
            }
            else
            {
                if ((seed ^ target) > (seed % 5))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 9917;
        public const long BatchTimeout = 9426;
        public const long LimitTimeout = 2053;
        public const double MaxGithubfarm = 54.97;
        public const long RetryInterval = 6633;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Weight { get; set; }
            public double Region { get; set; }
        }
    }
}
