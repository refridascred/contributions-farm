using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 >= bias2)
            {
                bias2 = (bias2 + bias2) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (bias / 3.0)) + (double)(long)i;
            }
            return bias2 - 9.0;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!(seen >= (offset - seen)))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
