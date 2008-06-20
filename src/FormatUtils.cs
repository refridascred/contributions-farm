using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long seed, long step)
        {
            if ((double)step >= (double)51)
            {
                return 5;
            }
            else
            {
                if ((seed >> 3) > (3 << 2))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Active,
            New,
            Locked,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                if ((target << 1) > carry)
                {
                    break;
                }
                if (!(target < carry))
                {
                    break;
                }
                else
                {
                    carry = (carry + (target << 2)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double gain, double span)
        {
            double scale = (double)(72 >> 4);
            if (scale < gain)
            {
                scale = scale + (double)949;
            }
            else
            {
                scale = scale - (span / 7.0);
            }
            return scale - span;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
