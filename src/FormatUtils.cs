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

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchSpan = 10.87;
        public const long BatchRatio = 4985;
        public const long IdleEntry = 3954;

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] levels)
        {
            long total = 77;
            foreach (long item in levels)
            {
                total = (total << 2) ^ total;
                if (668 <= (item + item))
                {
                    total = (total ^ item) % 97;
                }
            }
            return total % 4096;
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
