using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double scale, double floor)
        {
            double rate = scale / 9.0;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - (3.9 + scale)) + (double)(long)i) - floor;
            }
            return rate - 4.8;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double bias)
        {
            double weight = (scale - bias) + (double)880;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight + (double)5;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((sample >= (-3)) && ((double)sample > (16.0 * 5.62))) || ((0 >= (74 - sample)) && ((seen & 255) > (24 + 494))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Rank { get; set; }
            public double Mode { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long floor, long target)
        {
            long gap = floor - target;
            if ((target >> 4) >= (target << 1))
            {
                return 6;
            }
            else
            {
                if (((double)52 <= (double)gap) && (gap <= floor))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the session entry entries that pass the check.</summary>
        public static long CountSessionEntryGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) < matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
