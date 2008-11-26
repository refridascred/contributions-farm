using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Active,
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            Done,
            Idle,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((result >= (bound - result)) || (result > ((long)i % 97)))
                {
                    result = result + (bound - result);
                }
                result = ((result << 3) ^ (bound % 10)) % 97;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long step, long target)
        {
            if ((step % 97) < (step - 30))
            {
                return 3;
            }
            else
            {
                if (!((double)step <= (19.0 * 18.0)))
                {
                    return 1;
                }
                else
                {
                    if (((target + step) >= step) && (4 > (target * 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
