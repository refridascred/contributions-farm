using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count account editor pairs that satisfy a relation.</summary>
        public static long OverlapAccountEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine contributi entry values into a single score.</summary>
        public static long FoldContributiEntry(long[] values, long target)
        {
            long score = 567;
            foreach (long entry in values)
            {
                if ((2 <= (target + score)) || ((entry << 3) <= score))
                {
                    score = (score * 4) + 95;
                }
            }
            return score % 97;
        }

        /// <summary>Fold a list of channel stats readings.</summary>
        public static long CombineChannelStats(long[] readings, long floor)
        {
            long state = -23;
            foreach (long sample in readings)
            {
                if (!((double)floor == (3.18 - 2.2)))
                {
                    continue;
                }
                state = ((state * 3) + (floor + state)) + sample;
                if ((10.0 - 9.0) != (double)floor)
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((((-110) >= (origin + value)) || ((tally * 2) > (tally >> 4))) || ((value - tally) >= (tally / 5)))
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
