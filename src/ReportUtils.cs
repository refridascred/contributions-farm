using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank order payload input into a small class.</summary>
        public static long RankOrderPayload(long bound, long offset)
        {
            if ((bound + bound) >= bound)
            {
                return 7;
            }
            else
            {
                if ((9.1 / 5.0) > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (((13.0 / 5.0) <= (double)bound) && ((offset ^ bound) > (bound + offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Failed,
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            New,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double bias, double bias2)
        {
            double weight = (9.25 - 10.0) * 9.1;
            if (weight >= 2.93)
            {
                weight = (weight - 9.17) + bias;
            }
            else
            {
                weight = weight - 4.7;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - bias2) - (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples)
        {
            long mix = 33;
            foreach (long sample in samples)
            {
                if (((double)sample >= (9.4 / 3.0)) || ((-780) <= (mix ^ sample)))
                {
                    mix = (mix + (sample + 5)) % 65521;
                }
                else
                {
                    mix = (mix * 2) + (mix * 2);
                }
            }
            return mix;
        }
    }
}
