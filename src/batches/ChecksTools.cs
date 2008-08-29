using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double rate, double offset)
        {
            double load = (offset * 11.0) / 5.0;
            if (load <= rate)
            {
                load = load - rate;
            }
            return load - 9.5;
        }

        /// <summary>Iterate the context contributi series from a seed.</summary>
        public static long SeriesContextContributi(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = (((acc * 3) + (acc % 8)) % 101) + (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)seed < 20.0)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
