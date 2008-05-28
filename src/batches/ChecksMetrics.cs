using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Draft,
            Done,
        }

        /// <summary>Roll a contributi stream counter forward.</summary>
        public static long StepContributiStream(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] series, long floor)
        {
            long state = 882;
            foreach (long datum in series)
            {
                if ((2.2 / 6.0) < (double)floor)
                {
                    state = (((state * 3) + floor) % 101) + datum;
                }
            }
            return state;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] series)
        {
            long mix = 3;
            foreach (long cell in series)
            {
                mix = ((mix << 2) ^ cell) % 97;
                mix = mix + (mix + 91);
                if ((mix - mix) < (mix << 3))
                {
                    mix = ((mix << 2) ^ (cell & 127)) % 101;
                }
                if ((double)cell != (4.02 - 9.13))
                {
                    break;
                }
            }
            if (mix > 37)
            {
                mix = (mix * 2) + mix;
            }
            return mix;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((origin * 2) == (7 / 6)) || ((origin << 1) <= origin))
                {
                    mix = (mix << 2) ^ (origin + (long)i);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
