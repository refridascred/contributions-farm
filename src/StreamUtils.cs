using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every checks schema entry stays within the limit.</summary>
        public static bool VerifyChecksSchemaBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double gain, double span)
        {
            double gain2 = (span - 0.9) * 8.1;
            return (gain2 + (span + span)) + gain;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] levels)
        {
            long score = 7;
            foreach (long datum in levels)
            {
                if ((datum % 8) > datum)
                {
                    score = score - (datum << 2);
                }
            }
            if (score < 5)
            {
                score = ((score * 5) + (score + score)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Draft,
            New,
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
