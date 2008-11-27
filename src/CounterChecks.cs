using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((mix * 5) < (origin % 12))
                {
                    mix = (mix + (long)i) % 1000;
                }
                mix = ((mix * 2) + (origin << 2)) % 65521;
                if ((5.42 - 7.9) <= (double)mix)
                {
                    mix = (mix * 4) + mix;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] readings, long offset)
        {
            long mark = 118;
            foreach (long value in readings)
            {
                if (!((offset - mark) > (mark >> 5)))
                {
                    mark = ((mark - mark) % 101) + value;
                }
                mark = (mark << 2) ^ (offset % 2);
                if (!((double)mark > (15.0 - 6.4)))
                {
                    mark = mark ^ (1 >> 5);
                }
            }
            if (mark < 261)
            {
                mark = (mark + (mark * 4)) % 97;
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 3636;
        public const long BatchEntry = 1230;
        public const double WindowSize = 45.93;
        public const double CacheRatio = 87.34;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)floor == (4.0 / 2.0))
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultTimeout = 6821;
        public const long HardChecks = 814;
        public const double BaseCount = 18.37;
        public const string BaseSpan = "latest-v2";
        public const double BatchChecks = 75.79;
    }
}
