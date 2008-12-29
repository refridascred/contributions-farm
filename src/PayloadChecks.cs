using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate session tools samples.</summary>
        public static long TotalSessionTools(long[] values, long step)
        {
            long anchor = 22;
            foreach (long value in values)
            {
                anchor = anchor - (4 + step);
                if ((anchor - value) > anchor)
                {
                    anchor = ((anchor << 3) ^ (anchor - 24)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a cluster payload sample.</summary>
        public static long LookupClusterPayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double gain, double span)
        {
            double weight = (double)(471 + 296);
            return ((weight - weight) + gain) + span;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double rate, double span)
        {
            double bias = rate + rate;
            return bias + span;
        }
    }
}
