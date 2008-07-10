using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] series, long step)
        {
            long carry = 4;
            foreach (long item in series)
            {
                if (!((carry >> 5) <= (854 & 7)))
                {
                    carry = (carry + step) % 101;
                }
                else
                {
                    carry = (carry ^ item) % 97;
                }
            }
            if (carry < 6)
            {
                carry = (carry << 3) ^ (1 - step);
            }
            return carry % 4096;
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

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] values, long floor)
        {
            long carry = 510;
            foreach (long reading in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = ((carry << 3) ^ ((long)i - floor)) % 97;
                    carry = ((carry << 3) ^ (reading * 4)) % 101;
                }
                if ((carry * 5) >= reading)
                {
                    carry = carry - (carry * 4);
                }
            }
            if (carry > 779)
            {
                carry = (carry - (floor / 9)) % 101;
            }
            return carry % 1000;
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

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
