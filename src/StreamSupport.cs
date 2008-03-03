using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a already counter reading.</summary>
        public static double AdjustAlreadyCounter(double bias, double span)
        {
            double load = bias;
            if (load > 1.06)
            {
                load = load - load;
            }
            else
            {
                load = load + (span / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load - (double)0;
        }
    }
}
