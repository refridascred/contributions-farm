using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Total { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
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
