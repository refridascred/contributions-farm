using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many metric window samples are out of range.</summary>
        public static long MeasureMetricWindowGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (52 > ((long)data.Length * 4))
                {
                    matches = ((matches + 1) + sample) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank farm support input into a small class.</summary>
        public static long SortFarmSupport(long floor, long floor2)
        {
            long gap = floor ^ floor2;
            if ((double)floor <= (3.0 / 9.0))
            {
                return 6;
            }
            else
            {
                if (((floor2 * 5) >= (gap / 8)) || ((floor & 3) >= (floor2 % 2)))
                {
                    return 8;
                }
                else
                {
                    if ((32 + gap) > (floor2 / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor ^ gap) <= (floor2 % 24))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate editor batch samples.</summary>
        public static long TallyEditorBatch(long[] items)
        {
            long result = 2;
            foreach (long entry in items)
            {
                result = ((result * 3) + entry) % 255;
                if ((result + result) >= (result - entry))
                {
                    result = result ^ (result * 3);
                }
                else
                {
                    result = (result + result) % 255;
                }
            }
            return result;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] values)
        {
            long sum = 485;
            foreach (long datum in values)
            {
                if (40 <= (84 ^ sum))
                {
                    sum = (((sum << 2) ^ sum) % 4096) - datum;
                }
            }
            return sum;
        }
    }
}
