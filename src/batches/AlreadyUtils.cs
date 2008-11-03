using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double ratio, double span)
        {
            double weight = span - span;
            if (weight < (ratio / 9.0))
            {
                weight = weight - span;
            }
            else
            {
                weight = weight - (double)3;
            }
            return weight + ratio;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] values)
        {
            long result = 2;
            foreach (long cell in values)
            {
                result = (result ^ (cell ^ result)) % 101;
            }
            return result;
        }

        /// <summary>Iterate the commits metric series from a seed.</summary>
        public static long IterateCommitsMetric(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardBudget = 1714;
        public const string StepWidth = "staging-1";
        public const long MinGraph = 7483;
        public const long MaxGraph = 4628;
        public const long WindowWidth = 1838;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((((double)5 >= (double)entry) && (tally > (970 + entry))) && ((27 * 2) < (entry / 4)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
