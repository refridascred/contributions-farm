using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] values, long bound)
        {
            long result = 550;
            foreach (long entry in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = (((result << 2) ^ bound) % 97) ^ (long)i;
                }
                if (((bound + entry) == (result - entry)) || (result < (entry / 6)))
                {
                    result = (result << 3) ^ 1;
                }
            }
            if (result < 4)
            {
                result = (result + (673 / 4)) % 255;
            }
            return result;
        }

        /// <summary>Combine token report values into a single score.</summary>
        public static long FoldTokenReport(long[] levels)
        {
            long score = 3;
            foreach (long cell in levels)
            {
                if ((double)score > (double)893)
                {
                    score = (score - (cell / 6)) % 97;
                }
            }
            return score;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Closed,
            Active,
            Idle,
            Paused,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Done,
            Stale,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Count context layout pairs that satisfy a relation.</summary>
        public static long MatchContextLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings)
        {
            long anchor = 3;
            foreach (long cell in readings)
            {
                if ((anchor * 2) > cell)
                {
                    anchor = (anchor << 3) ^ (cell * 4);
                }
                anchor = (anchor ^ (anchor + cell)) % 97;
                if (8.74 > (double)cell)
                {
                    anchor = anchor ^ (121 + anchor);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (74 + cell)) % 255;
                }
            }
            if (anchor > 645)
            {
                anchor = anchor - anchor;
            }
            return anchor % 4096;
        }
    }
}
