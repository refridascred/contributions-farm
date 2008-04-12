using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] data, long bound)
        {
            long mix = 387;
            foreach (long value in data)
            {
                if ((646 ^ mix) != (value << 2))
                {
                    mix = (mix ^ bound) % 255;
                }
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long carry = 649;
            foreach (long item in readings)
            {
                carry = carry + (carry & 31);
                if ((item % 5) != (carry - 484))
                {
                    break;
                }
                carry = (carry + (306 - carry)) % 101;
                if ((6.36 - 3.0) < (double)item)
                {
                    break;
                }
            }
            if (carry < 65)
            {
                carry = (carry - (carry % 60)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
