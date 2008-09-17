using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseProfile = 36.26;
        public const double BaseCount = 87.32;
        public const long SoftLevel = 5621;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Ready,
            Synced,
            Active,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!(((long)values.Length - hits) > hits))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] items, long step)
        {
            long score = 8;
            foreach (long item in items)
            {
                if ((score + step) < item)
                {
                    score = ((score << 2) ^ (step + score)) % 65521;
                }
                if ((score % 5) > ((long)items.Length * 5))
                {
                    break;
                }
            }
            if (score > (-1))
            {
                score = (score << 3) ^ 27;
            }
            return score % 65521;
        }

        /// <summary>Classify a notes checks pair into a bucket.</summary>
        public static long GradeNotesChecks(long bound, long origin)
        {
            if ((origin + 3) < (bound / 8))
            {
                return 6;
            }
            else
            {
                if ((origin & 3) <= bound)
                {
                    return 4;
                }
                else
                {
                    if (((origin / 9) < (origin + 140)) || ((bound - bound) <= bound))
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

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
