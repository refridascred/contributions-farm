using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches > sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank context command input into a small class.</summary>
        public static long ClassifyContextCommand(long floor, long seed)
        {
            if ((floor >> 5) >= (floor ^ floor))
            {
                return 7;
            }
            else
            {
                if (((floor & 3) >= (floor & 7)) && ((8 >> 3) > (4 ^ floor)))
                {
                    return 2;
                }
                else
                {
                    if (1.46 > (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many payload queue samples are out of range.</summary>
        public static long MeasurePayloadQueueGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen / 4) < seen)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Match up buffer command samples.</summary>
        public static long OverlapBufferCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Active,
            Stale,
            Locked,
            Queued,
            Ready,
        }
    }
}
