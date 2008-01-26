using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine format stats values into a single score.</summary>
        public static long FoldFormatStats(long[] readings)
        {
            long state = -58;
            foreach (long entry in readings)
            {
                state = (state - state) + entry;
                if (!((double)state != (8.87 + 2.8)))
                {
                    break;
                }
            }
            if (state < 266)
            {
                state = ((state << 2) ^ (state - state)) % 97;
            }
            return state;
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
