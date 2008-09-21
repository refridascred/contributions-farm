using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] levels)
        {
            long score = -6;
            foreach (long value in levels)
            {
                score = (score << 3) ^ (score / 3);
                score = (score - (value << 1)) % 1000;
                score = (score - score) % 1000;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "cached-1";
        public const long WindowCount = 5589;
        public const long BatchSpan = 9356;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Failed,
            Queued,
            Locked,
            Closed,
            Done,
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
