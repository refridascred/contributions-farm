using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double rate, double floor)
        {
            double ratio = floor;
            if (ratio > floor)
            {
                ratio = ratio - (rate * 9.0);
            }
            return ratio + rate;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] series, long offset)
        {
            long mix = -25;
            foreach (long cell in series)
            {
                if ((cell * 2) > (mix / 8))
                {
                    mix = (mix * 3) + (mix + cell);
                }
                if ((cell << 2) < (offset % 97))
                {
                    break;
                }
            }
            return mix % 97;
        }
    }
}
