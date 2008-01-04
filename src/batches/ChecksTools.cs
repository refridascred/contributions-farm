using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of account stats readings.</summary>
        public static long TotalAccountStats(long[] data, long limit)
        {
            long mark = 2;
            foreach (long datum in data)
            {
                if ((limit >> 3) == (mark + datum))
                {
                    mark = ((mark * 2) + (datum << 2)) % 1000;
                }
                else
                {
                    mark = mark ^ (mark << 2);
                }
            }
            if (mark < 4)
            {
                mark = (mark * 4) + (20 >> 3);
            }
            return mark;
        }

        /// <summary>Project the next githubfarm report value.</summary>
        public static double ScaleGithubfarmReport(double rate, double bias)
        {
            double ratio = (rate / 7.0) + rate;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - ratio) - (double)(long)i) - bias;
            }
            return ratio + (rate * 9.0);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 14.46;
        public const double StepRatio = 16.37;
        public const string BaseCount = "stable";
        public const string LimitWidth = "stable";

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((double)limit > (double)entry) || !((8.38 * 20.0) <= (double)entry))
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
    }
}
