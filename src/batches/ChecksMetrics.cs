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

        /// <summary>Scale a contributi already figure with a bias.</summary>
        public static double BlendContributiAlready(double ratio, double bias)
        {
            double scale = (double)5 + bias;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - (ratio - ratio);
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
