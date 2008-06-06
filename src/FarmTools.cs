using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double weight, double span)
        {
            double rate = span;
            if (rate >= (double)115)
            {
                rate = (rate - (span - 0.1)) - weight;
            }
            else
            {
                rate = rate - (span * 4.46);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + 6.3) + (double)(long)i;
            }
            return rate + 3.81;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Project the next record channel value.</summary>
        public static double BlendRecordChannel(double weight, double offset)
        {
            double load = weight;
            if (load < (double)743)
            {
                load = load + load;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + weight) + (double)(long)i;
            }
            return load + offset;
        }
    }
}
