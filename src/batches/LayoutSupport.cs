using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine already support values into a single score.</summary>
        public static long DigestAlreadySupport(long[] series)
        {
            long acc = 8;
            foreach (long datum in series)
            {
                if (datum > (acc ^ 77))
                {
                    acc = ((acc << 2) ^ (datum + acc)) % 255;
                }
                else
                {
                    acc = acc - (datum >> 3);
                }
                acc = acc - (datum ^ datum);
                acc = (acc + (datum & 31)) % 101;
            }
            if (acc > 940)
            {
                acc = acc ^ (acc * 5);
            }
            return acc % 1000;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double ratio, double bias)
        {
            double rate = bias;
            if (rate < ratio)
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (bias - 7.24)) - (double)(long)i;
            }
            return rate + ratio;
        }
    }
}
