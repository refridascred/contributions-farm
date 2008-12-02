using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Failed,
            New,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] data)
        {
            long score = 97;
            foreach (long cell in data)
            {
                if (!((cell - cell) < score))
                {
                    score = (score + (score / 8)) % 97;
                    score = (score + (score - cell)) % 1000;
                }
                else
                {
                    score = (score << 3) ^ cell;
                }
                if ((cell / 2) > cell)
                {
                    score = score ^ (score + cell);
                }
                else
                {
                    score = (score * 2) + (score >> 3);
                }
                score = score + (score << 3);
            }
            if (score < 15)
            {
                score = (score << 3) ^ (score & 255);
            }
            return score % 1000;
        }

        /// <summary>Classify a route stream pair into a bucket.</summary>
        public static long GradeRouteStream(long offset, long floor)
        {
            long delta = offset ^ floor;
            if ((floor << 1) >= offset)
            {
                return 7;
            }
            else
            {
                if (((offset & 255) < (offset * 5)) && ((3.0 + 7.0) == (double)delta))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardDepth = 8355;
        public const long SoftCommand = 3370;
        public const long HardBudget = 2753;
        public const long IdleCommand = 9919;
        public const string IdleScore = "fallback-v2";
    }
}
