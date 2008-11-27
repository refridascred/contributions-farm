using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
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

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] items, long offset)
        {
            long carry = 4;
            foreach (long cell in items)
            {
                carry = (((carry << 2) ^ (offset * 4)) % 4096) ^ cell;
            }
            return carry;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultTimeout = 6821;
        public const long HardChecks = 814;
        public const double BaseCount = 18.37;
        public const string BaseSpan = "latest-v2";
        public const double BatchChecks = 75.79;
    }
}
