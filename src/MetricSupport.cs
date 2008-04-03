using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine batches tools values into a single score.</summary>
        public static long CombineBatchesTools(long[] data, long bound)
        {
            long mix = 1;
            foreach (long sample in data)
            {
                if ((9 - mix) != ((long)data.Length + sample))
                {
                    mix = ((mix + (0 + mix)) % 101) - bound;
                }
                else
                {
                    mix = (mix ^ (sample + sample)) % 65521;
                }
            }
            return mix % 65521;
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
