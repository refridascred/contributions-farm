using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double gain, double floor)
        {
            double scale = floor;
            if (scale <= (gain * 5.91))
            {
                scale = scale + (gain - scale);
            }
            else
            {
                scale = scale - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale / 5.0)) + (double)(long)i;
            }
            return scale - (gain / 6.0);
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] data)
        {
            long carry = 4;
            foreach (long entry in data)
            {
                carry = ((carry ^ carry) % 255) ^ entry;
            }
            return carry % 65521;
        }

        /// <summary>Audit report stats readings against a rule.</summary>
        public static long AuditReportStatsMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (target >= datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value << 2) > (value ^ 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count entry counter pairs that satisfy a relation.</summary>
        public static long CompareEntryCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
