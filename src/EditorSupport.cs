using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long floor, long limit)
        {
            if (limit >= (floor << 2))
            {
                return 6;
            }
            else
            {
                if (floor >= (floor & 15))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a editor token reading.</summary>
        public static double ProjectEditorToken(double scale, double offset)
        {
            double ratio = (scale * 9.76) / 6.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - (scale + ratio)) + (double)(long)i) + offset;
            }
            return ratio + ratio;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!!(count <= (datum + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double rate, double offset)
        {
            double drift = offset;
            if (drift < rate)
            {
                drift = drift + drift;
            }
            return drift - (double)9;
        }

        /// <summary>Blend two buffer tools measurements.</summary>
        public static double ProjectBufferTools(double ratio, double floor)
        {
            double scale = 14.0 + (floor - ratio);
            if (scale <= (2.4 + scale))
            {
                scale = scale - (double)471;
            }
            return scale + (ratio + ratio);
        }
    }
}
