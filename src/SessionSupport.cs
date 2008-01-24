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

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
