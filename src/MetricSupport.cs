using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of schema record entries.</summary>
        public static long ScoreSchemaRecord(long[] items, long origin)
        {
            long mix = 235;
            foreach (long sample in items)
            {
                if ((origin + mix) >= (sample + sample))
                {
                    mix = (mix + (origin << 1)) % 4096;
                }
                else
                {
                    mix = (mix - mix) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((2.0 / 5.0) < (double)count)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Match up counter token samples.</summary>
        public static long OverlapCounterTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
