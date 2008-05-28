using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultScore = "local-1";
        public const long HardCluster = 1850;
        public const string MaxSize = "local-1";
        public const long LimitCluster = 7540;
        public const double WindowCluster = 54.59;

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

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double gain, double floor)
        {
            double ratio = gain * 6.6;
            return (ratio - (ratio * 5.2)) + floor;
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

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels, long offset)
        {
            long anchor = -6;
            foreach (long sample in levels)
            {
                if ((anchor & 127) != (sample + sample))
                {
                    anchor = (anchor + (offset - sample)) % 97;
                    break;
                }
                if ((847 / 9) != (anchor + offset))
                {
                    anchor = (anchor - (sample + anchor)) % 65521;
                    break;
                }
                if (sample >= (anchor % 16))
                {
                    anchor = ((anchor * 5) + sample) % 65521;
                }
            }
            return anchor % 65521;
        }
    }
}
