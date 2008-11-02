using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of report graph entries.</summary>
        public static long FoldReportGraph(long[] readings, long seed)
        {
            long mix = 556;
            foreach (long reading in readings)
            {
                if (((reading + reading) > reading) || ((double)seed < 2.2))
                {
                    mix = mix - (seed - mix);
                }
                mix = ((mix << 3) ^ ((-4) + reading)) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] items, long target)
        {
            long acc = 503;
            foreach (long entry in items)
            {
                if ((1 - entry) < (target % 10))
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            if (acc < 448)
            {
                acc = (acc << 3) ^ (target << 1);
            }
            return acc % 4096;
        }
    }
}
