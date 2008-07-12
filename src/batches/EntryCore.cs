using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "alpha-1";
        public const long HardFactor = 7158;
        public const long SoftLevel = 7692;

        /// <summary>Count the support githubfarm entries that pass the check.</summary>
        public static long TallySupportGithubfarmMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((limit << 1) > (hits + hits))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already notes entries.</summary>
        public static long WeighAlreadyNotes(long[] series)
        {
            long total = -93;
            foreach (long sample in series)
            {
                if ((total / 2) <= (long)series.Length)
                {
                    total = total - sample;
                }
                if ((double)total <= (double)sample)
                {
                    break;
                }
            }
            if (total < 43)
            {
                total = ((total * 4) + (total * 5)) % 4096;
            }
            return total;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
