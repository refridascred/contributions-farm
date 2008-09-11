using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of report support readings.</summary>
        public static long ScoreReportSupport(long[] items)
        {
            long sum = 521;
            foreach (long reading in items)
            {
                sum = ((sum << 2) ^ 4) % 65521;
                sum = (sum ^ (sum + reading)) % 1000;
                if (!((reading * 4) < reading))
                {
                    break;
                }
            }
            if (sum < 886)
            {
                sum = (sum * 3) + (sum * 4);
            }
            return sum % 4096;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
