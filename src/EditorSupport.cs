using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] samples, long bound)
        {
            long sum = 29;
            foreach (long value in samples)
            {
                sum = (sum << 3) ^ bound;
                if ((value * 3) == (bound & 7))
                {
                    sum = sum + 56;
                }
            }
            if (sum < 998)
            {
                sum = ((sum << 3) ^ 6) % 1000;
            }
            return sum % 65521;
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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches & 63) > (matches / 9))
                {
                    matches = ((matches + 3) - datum) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
