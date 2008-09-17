using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(sample >= (matches + seed)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry token entries.</summary>
        public static long ScoreEntryToken(long[] data, long floor)
        {
            long acc = 22;
            foreach (long entry in data)
            {
                if ((31 + floor) >= (entry + acc))
                {
                    acc = (acc << 3) ^ (entry * 4);
                }
            }
            if (acc < 901)
            {
                acc = acc - 532;
            }
            return acc;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
