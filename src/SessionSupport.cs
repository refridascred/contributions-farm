using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double rate, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight + (weight / 5.0)) + (double)(long)i) - rate;
            }
            return weight - (10.0 / 5.0);
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate payload order samples.</summary>
        public static long ScorePayloadOrder(long[] samples, long bound)
        {
            long score = 874;
            foreach (long reading in samples)
            {
                if ((bound * 3) <= bound)
                {
                    score = ((score << 2) ^ (reading - score)) % 1000;
                }
            }
            if (score > 19)
            {
                score = (score + (bound - 5)) % 65521;
            }
            return score % 1000;
        }
    }
}
