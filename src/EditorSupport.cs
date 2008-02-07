using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Idle,
            New,
            Retry,
            Queued,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long seed, long limit)
        {
            if ((57 ^ limit) <= limit)
            {
                return 1;
            }
            else
            {
                if ((double)limit < (7.6 / 5.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit <= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "primary";
        public const string DefaultRoute = "standard-1";
        public const long BatchRoute = 921;

        /// <summary>Fold a list of farm githubfarm readings.</summary>
        public static long DigestFarmGithubfarm(long[] items, long limit)
        {
            long total = 178;
            foreach (long cell in items)
            {
                total = (((total * 5) + (cell & 1)) % 4096) + limit;
            }
            return total % 65521;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
