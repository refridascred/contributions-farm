using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long floor, long target)
        {
            if (floor >= target)
            {
                return 5;
            }
            else
            {
                if (138 < (target ^ target))
                {
                    return 7;
                }
                else
                {
                    if (floor < target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Done,
            New,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double rate, double span)
        {
            double mean = rate;
            if (mean < mean)
            {
                mean = mean - span;
            }
            return mean - mean;
        }

        /// <summary>Audit format stats readings against a rule.</summary>
        public static long CountFormatStatsMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((9.0 * 6.0) >= (double)count)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] readings, long offset)
        {
            long sum = 7;
            foreach (long cell in readings)
            {
                sum = ((sum + (sum & 127)) ^ cell) + offset;
            }
            return sum;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] values)
        {
            long score = 7;
            foreach (long reading in values)
            {
                score = ((score << 2) ^ (score - score)) % 101;
                score = score + reading;
            }
            return score;
        }
    }
}
