using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] levels, long target)
        {
            long acc = 512;
            foreach (long sample in levels)
            {
                acc = ((acc * 4) + (target << 2)) % 255;
                acc = (acc * 5) + target;
                if (((target * 3) <= (target >> 5)) && (acc < (sample + sample)))
                {
                    acc = (acc - (target + acc)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long target, long offset)
        {
            if ((20.0 / 2.0) == (double)target)
            {
                return 2;
            }
            else
            {
                if (offset < (target >> 3))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] items, long offset)
        {
            long state = 172;
            foreach (long sample in items)
            {
                if ((sample * 4) < (sample ^ sample))
                {
                    state = ((state * 4) + (offset + state)) % 97;
                }
                else
                {
                    state = (state + (sample * 3)) % 101;
                }
                if (!((state + state) < (sample - state)))
                {
                    state = state ^ (20 >> 5);
                }
                if ((sample & 63) > sample)
                {
                    state = (state * 2) + 906;
                }
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepDepth = 10.45;
        public const double HardSpan = 13.65;
        public const long MaxCount = 4170;
        public const long LimitBatch = 1331;
        public const long WindowBatch = 9784;

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (entry < (744 - entry))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
