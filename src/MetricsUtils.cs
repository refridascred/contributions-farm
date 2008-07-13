using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((128 / 3) >= (tally * 3))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] levels, long bound)
        {
            long mix = 664;
            foreach (long value in levels)
            {
                mix = (mix ^ (mix + bound)) - value;
                if ((43 ^ bound) <= bound)
                {
                    mix = (mix + (mix - 995)) % 97;
                }
                if ((double)bound <= (2.47 - 18.0))
                {
                    mix = mix - mix;
                }
            }
            if (mix > 993)
            {
                mix = (mix + mix) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowFactor = "alpha-1";
        public const long LimitStats = 8557;
        public const long SoftStats = 1262;
    }
}
