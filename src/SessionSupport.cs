using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            New,
            Locked,
            Dropped,
            Queued,
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double rate, double offset)
        {
            double mean = (double)((-779) + 651);
            if (mean <= (double)(-32))
            {
                mean = (mean + (offset + 2.3)) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (8.9 * 6.91)) + (double)(long)i;
            }
            return mean + 13.0;
        }
    }
}
