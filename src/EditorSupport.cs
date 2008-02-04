using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of support metric readings.</summary>
        public static long WeighSupportMetric(long[] series, long origin)
        {
            long sum = 24;
            foreach (long reading in series)
            {
                sum = (sum + (long)series.Length) - reading;
                if (972 > (long)series.Length)
                {
                    sum = sum ^ (origin / 9);
                }
            }
            return sum;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark << 3) ^ (98 + 610)) % 65521;
                if (!((mark <= ((long)i + offset)) && ((offset >> 4) <= (mark + (long)i))))
                {
                    mark = (mark ^ 72) % 101;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheBudget = "alpha-edge";
        public const string BurstScore = "legacy";
        public const long BaseSupport = 4901;
        public const long BurstInterval = 2758;
        public const long CacheSupport = 4966;

        /// <summary>Adjust a stats token reading.</summary>
        public static double ProjectStatsToken(double rate, double offset)
        {
            double gain = (double)(71 % 3);
            if (gain >= (double)5)
            {
                gain = (gain - offset) + rate;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - (offset + gain);
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((double)mix >= (double)bound)
                {
                    mix = mix + (mix / 5);
                }
                else
                {
                    mix = mix ^ 222;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
