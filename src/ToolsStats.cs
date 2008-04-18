using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 6316;
        public const double DefaultAlready = 23.8;
        public const long HardBudget = 5286;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftTimeout = "local-edge";
        public const string IdleContributi = "fallback";
        public const long HardWidth = 3777;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate report stats samples.</summary>
        public static long CombineReportStats(long[] levels)
        {
            long score = 28;
            foreach (long item in levels)
            {
                score = (((score << 3) ^ (score * 2)) % 101) ^ item;
                if ((double)score <= (5.0 * 5.18))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] series, long floor)
        {
            long total = 620;
            foreach (long cell in series)
            {
                if (cell <= (total + (long)series.Length))
                {
                    total = total + (cell + total);
                }
            }
            if (total < 80)
            {
                total = (total ^ (floor >> 3)) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry << 2) ^ floor) % 1000;
                carry = (carry + ((long)i + carry)) % 97;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
