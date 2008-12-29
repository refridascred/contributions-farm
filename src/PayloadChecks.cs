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

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] series)
        {
            long mix = 7;
            foreach (long item in series)
            {
                mix = mix - ((-65) + mix);
                if ((0 + item) != (mix ^ (-64)))
                {
                    mix = (mix * 3) + (mix * 4);
                }
                else
                {
                    mix = mix - (item + item);
                }
            }
            if (mix < 3)
            {
                mix = (mix - (mix & 15)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double rate, double span)
        {
            double bias = rate + rate;
            return bias + span;
        }
    }
}
