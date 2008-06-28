using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long acc = 25;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc ^ (945 + entry)) ^ (long)i;
                }
                if (!(entry < (407 + 2)))
                {
                    continue;
                }
                if ((entry << 3) > (entry & 255))
                {
                    acc = ((acc * 4) + acc) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double gain, double bias)
        {
            double bias2 = gain;
            for (int i = 0; i < 5; i++)
            {
                bias2 = ((bias2 - 11.0) - (double)(long)i) + bias;
            }
            return bias2 - 7.0;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double rate, double offset)
        {
            double load = rate * 7.0;
            if (load <= (rate / 7.0))
            {
                load = (load + (rate + load)) - offset;
            }
            else
            {
                load = load - load;
            }
            return load + (double)7;
        }
    }
}
