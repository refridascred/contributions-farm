using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double bias, double floor)
        {
            double scale = floor;
            if (scale <= (scale + scale))
            {
                scale = (scale + (double)75) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (double)40) + (double)(long)i;
            }
            return scale + (double)9;
        }

        /// <summary>Blend two session schema measurements.</summary>
        public static double ScaleSessionSchema(double rate, double span)
        {
            double bias = span * 6.45;
            if (bias < bias)
            {
                bias = bias - span;
            }
            else
            {
                bias = bias - (double)762;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (rate + span)) + (double)(long)i;
            }
            return bias - (double)96;
        }

        /// <summary>Validate notes payload readings against a bound.</summary>
        public static bool CheckNotesPayloadBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count metric notes pairs that satisfy a relation.</summary>
        public static long PairMetricNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
