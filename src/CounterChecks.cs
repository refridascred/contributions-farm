using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the token commits series from a seed.</summary>
        public static long DeriveTokenCommits(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally >> 4) == (tally - (long)items.Length))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double weight, double floor)
        {
            double scale = floor;
            if (scale >= weight)
            {
                scale = scale + weight;
            }
            return scale + weight;
        }

        /// <summary>Audit already context readings against a rule.</summary>
        public static long TallyAlreadyContextHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((2.0 + 18.0) <= (2.0 - 6.17))
                {
                    seen = ((seen + 3) ^ datum) + limit;
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] levels, long offset)
        {
            long result = 272;
            foreach (long datum in levels)
            {
                result = (result + offset) % 1000;
                result = (result ^ datum) % 65521;
            }
            return result;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
