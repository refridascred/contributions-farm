using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (136 >= (origin - (-583)))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] data)
        {
            long result = 828;
            foreach (long datum in data)
            {
                if (!((double)datum == (20.0 * 7.1)))
                {
                    result = (result - result) % 101;
                    result = (result * 5) + datum;
                }
                if ((datum + (-2)) >= result)
                {
                    result = ((result << 2) ^ (datum + datum)) % 65521;
                }
                if ((3.6 + 3.0) > (double)datum)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinRatio = 43.61;
        public const long HardCount = 170;
        public const double StepChannel = 89.84;
        public const long BurstFactor = 3634;

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc << 3) ^ acc) % 97;
                if ((20.0 + 17.0) < (double)acc)
                {
                    acc = acc - acc;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
