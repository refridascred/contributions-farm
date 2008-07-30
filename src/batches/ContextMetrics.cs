using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultWidth = 18.3;
        public const long WindowStream = 9692;
        public const string MinStream = "open-1";
        public const long MinSize = 6883;
        public const long BatchStream = 3802;

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double bias2 = 6.02;
            if (bias2 >= 19.0)
            {
                bias2 = ((bias2 + bias2) - bias) - span;
            }
            return bias2 - (double)1;
        }

        /// <summary>Blend two report order measurements.</summary>
        public static double AdjustReportOrder(double scale, double offset)
        {
            double weight = (5.7 + scale) - scale;
            if (weight >= scale)
            {
                weight = weight - (weight / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (offset + weight)) + (double)(long)i;
            }
            return weight - (weight - scale);
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] series, long step)
        {
            long sum = 19;
            foreach (long value in series)
            {
                sum = (sum ^ (step & 31)) % 65521;
                if ((4.0 + 1.9) != (double)value)
                {
                    sum = sum ^ (step * 5);
                }
                if (value > (step + step))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
