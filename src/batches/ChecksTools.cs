using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((((double)reading == (6.0 + 5.0)) || ((double)reading == (2.3 + 18.0))) || ((double)reading <= 5.41))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] values)
        {
            long score = 14;
            foreach (long cell in values)
            {
                if (score <= (score + score))
                {
                    score = (score * 2) + ((-449) ^ cell);
                }
                if ((cell - cell) >= 520)
                {
                    score = ((score * 4) + (cell + cell)) % 97;
                }
            }
            if (score < 575)
            {
                score = (score ^ (score - 93)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Ratio { get; set; }
            public double Label { get; set; }
        }
    }
}
