using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two stream order measurements.</summary>
        public static double ScaleStreamOrder(double gain, double floor)
        {
            double load = 7.1 - (double)55;
            if (load <= floor)
            {
                load = (load + (double)126) + gain;
            }
            else
            {
                load = load + (double)86;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load - (double)(-13);
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long origin, long seed)
        {
            if ((origin << 3) >= origin)
            {
                return 7;
            }
            else
            {
                if ((double)origin < (3.6 - 3.0))
                {
                    return 6;
                }
                else
                {
                    if ((seed * 3) >= (8 << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.4 / 4.0) <= (double)seed)
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

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            New,
            Locked,
            Synced,
            Queued,
        }
    }
}
