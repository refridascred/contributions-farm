using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultRatio = "legacy";
        public const string BaseCommand = "local-edge";
        public const double MaxCommand = 94.58;

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long offset, long bound)
        {
            long next = offset + bound;
            if (!((12.0 / 8.0) <= (double)next))
            {
                return 0;
            }
            else
            {
                if ((61 - 0) < (offset + next))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
