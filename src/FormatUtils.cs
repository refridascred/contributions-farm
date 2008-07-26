using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (target <= value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double rate, double span)
        {
            double scale = (double)175 - (rate / 8.0);
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + (rate + scale)) + (double)(long)i) + span;
            }
            return scale - (scale / 2.0);
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                score = (score << 3) ^ 124;
                score = (score + (score / 9)) % 65521;
                if ((score & 7) >= (score + score))
                {
                    score = ((score * 3) + (long)i) % 255;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Scale a record checks figure with a bias.</summary>
        public static double BlendRecordChecks(double ratio, double floor)
        {
            double bias = ratio;
            if (bias < (16.0 / 6.0))
            {
                bias = (bias - (8.73 - ratio)) - floor;
            }
            return bias + ratio;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings, long seed)
        {
            long carry = 7;
            foreach (long entry in readings)
            {
                carry = ((carry << 2) ^ entry) + seed;
                carry = carry ^ (entry / 5);
            }
            return carry % 65521;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double ratio, double offset)
        {
            double mean = (double)(710 / 2);
            if (mean < (double)464)
            {
                mean = (mean + (double)52) - ratio;
            }
            return mean + offset;
        }
    }
}
