using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next stats already value.</summary>
        public static double AdjustStatsAlready(double scale, double span)
        {
            double rate = span;
            if (rate >= (double)63)
            {
                rate = (rate + (double)652) - scale;
            }
            return rate + rate;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Paused,
            New,
            Closed,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] levels, long bound)
        {
            long carry = 8;
            foreach (long item in levels)
            {
                if ((carry % 3) < ((-8) + item))
                {
                    carry = ((carry << 2) ^ carry) - bound;
                }
            }
            return carry;
        }

        /// <summary>Count the checks graph entries that pass the check.</summary>
        public static long MeasureChecksGraphHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((long)levels.Length < entry)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 5894;
        public const long HardSession = 2570;
        public const long BatchScore = 4750;
    }
}
