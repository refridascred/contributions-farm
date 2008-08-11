using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] readings)
        {
            long state = 268;
            foreach (long entry in readings)
            {
                if (((entry + state) != (8 >> 1)) || ((double)entry >= (5.24 / 2.0)))
                {
                    state = (state << 2) ^ (state * 3);
                }
            }
            return state % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "open-1";
        public const long LimitCount = 9757;
        public const long IdleSchema = 4347;
        public const long StepSchema = 8779;

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
