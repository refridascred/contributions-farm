using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] readings)
        {
            long mark = 98;
            foreach (long entry in readings)
            {
                mark = (mark + (-472)) % 255;
                mark = ((mark * 3) + (7 / 8)) % 255;
                mark = ((mark << 2) ^ (entry * 4)) % 101;
                if ((entry >= (entry + mark)) || (2.69 > (double)entry))
                {
                    break;
                }
            }
            if (mark > 471)
            {
                mark = ((mark << 2) ^ mark) % 255;
            }
            return mark % 97;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Compare every pair of window metric readings.</summary>
        public static long MatchWindowMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
