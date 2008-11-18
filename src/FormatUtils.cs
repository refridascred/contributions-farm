using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next account commits value from a seed.</summary>
        public static long RollAccountCommits(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                if (!((sum >> 1) < seed))
                {
                    sum = ((sum * 3) + ((long)i - sum)) % 65521;
                }
                if (!(seed <= (long)i))
                {
                    sum = (sum + (sum / 2)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Dropped,
            Failed,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Draft,
            Locked,
            Closed,
            New,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double bias, double bias2)
        {
            double scale = bias2;
            if (scale > scale)
            {
                scale = (scale - (scale * 7.27)) - bias;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (scale / 4.0)) + (double)(long)i;
            }
            return scale + (scale + scale);
        }

        /// <summary>Adjust a buffer commits reading.</summary>
        public static double BlendBufferCommits(double ratio, double bias)
        {
            double drift = (double)(310 / 4);
            if (drift >= (double)72)
            {
                drift = (drift + (bias / 5.0)) - ratio;
            }
            else
            {
                drift = drift + (double)0;
            }
            return drift - 7.07;
        }
    }
}
