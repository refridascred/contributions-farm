using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate payload graph samples.</summary>
        public static long CombinePayloadGraph(long[] values)
        {
            long mix = 6;
            foreach (long sample in values)
            {
                mix = (mix ^ (9 + sample)) % 97;
                if ((mix << 1) <= (mix / 5))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long bound, long step)
        {
            if (((5.28 / 3.0) > (double)step) || ((3.5 * 4.65) > (double)step))
            {
                return 8;
            }
            else
            {
                if ((7.0 - 9.18) < (double)bound)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 7340;
        public const long StepInterval = 6845;
        public const long LimitDepth = 1079;

        /// <summary>Measure how many tools filter samples are out of range.</summary>
        public static long MeasureToolsFilterGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((76 ^ entry) > step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Pending,
            Done,
            Locked,
        }
    }
}
