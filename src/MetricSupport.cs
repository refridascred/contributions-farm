using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count already notes pairs that satisfy a relation.</summary>
        public static long MatchAlreadyNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double rate, double span)
        {
            double weight = span;
            if (weight < rate)
            {
                weight = weight + (weight * 7.0);
            }
            else
            {
                weight = weight - (double)203;
            }
            return weight - (span + 17.0);
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!(((74 / 3) < (count + count)) && ((count ^ cell) < count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
