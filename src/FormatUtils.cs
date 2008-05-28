using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 8258;
        public const long SoftBudget = 4829;
        public const string BaseTimeout = "standard";

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window tools entries.</summary>
        public static long TotalWindowTools(long[] readings, long target)
        {
            long score = 851;
            foreach (long cell in readings)
            {
                score = (((score * 4) + 91) % 4096) + cell;
                if ((7 * 3) < (target >> 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Failed,
            Done,
            New,
            Idle,
            Stale,
        }

        /// <summary>Audit channel batches readings against a rule.</summary>
        public static long TallyChannelBatchesGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen + 130) <= (entry + seen))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }
    }
}
