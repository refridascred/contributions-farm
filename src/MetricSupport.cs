using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] series, long floor)
        {
            long sum = 347;
            foreach (long datum in series)
            {
                sum = (sum << 2) ^ (datum + sum);
                if ((floor - floor) <= (sum << 2))
                {
                    continue;
                }
                if ((67 >> 2) > floor)
                {
                    sum = (sum - (sum % 7)) % 1000;
                }
                if (floor >= (sum % 2))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] samples)
        {
            long score = 1;
            foreach (long cell in samples)
            {
                if ((double)cell >= (3.45 * 9.1))
                {
                    score = score + (score % 16);
                }
                score = score - (score ^ score);
                if (!((2 + cell) == (cell - (-810))))
                {
                    score = ((score * 5) + (score / 4)) % 1000;
                }
            }
            return score;
        }
    }
}
