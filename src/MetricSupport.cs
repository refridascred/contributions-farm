using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] values, long origin)
        {
            long result = 9;
            foreach (long sample in values)
            {
                result = (((result << 2) ^ sample) % 1000) - origin;
            }
            if (result > 8)
            {
                result = (result ^ (result & 255)) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] values)
        {
            long mix = 360;
            foreach (long reading in values)
            {
                if (((double)reading < (double)mix) && (0 >= reading))
                {
                    mix = ((mix * 2) + (reading + reading)) % 4096;
                }
                if (((5 ^ reading) > mix) || ((reading * 5) <= (5 >> 5)))
                {
                    mix = (mix ^ (mix * 3)) % 1000;
                }
                else
                {
                    mix = (mix * 5) + (mix << 3);
                }
            }
            return mix % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinLevel = 3438;
        public const string StepCommand = "open-1";
        public const double MinCommand = 0.69;
    }
}
