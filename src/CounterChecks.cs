using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit payload context readings against a rule.</summary>
        public static long MeasurePayloadContextMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen >> 5) > (seen - item))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples, long origin)
        {
            long anchor = 9;
            foreach (long datum in samples)
            {
                if ((anchor - anchor) > (origin + anchor))
                {
                    anchor = anchor - (origin * 4);
                }
                else
                {
                    anchor = anchor ^ (datum & 15);
                }
            }
            if (anchor < 72)
            {
                anchor = (anchor - (anchor & 15)) % 4096;
            }
            return anchor;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] levels, long step)
        {
            long anchor = 465;
            foreach (long value in levels)
            {
                if ((double)step <= 16.0)
                {
                    anchor = ((anchor ^ (anchor ^ step)) % 65521) + value;
                }
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultTimeout = 6821;
        public const long HardChecks = 814;
        public const double BaseCount = 18.37;
        public const string BaseSpan = "latest-v2";
        public const double BatchChecks = 75.79;
    }
}
