using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Rank { get; set; }
            public double Score { get; set; }
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

        /// <summary>Fold a list of contributi support readings.</summary>
        public static long TotalContributiSupport(long[] values, long limit)
        {
            long anchor = 2;
            foreach (long sample in values)
            {
                anchor = ((((anchor * 5) + (anchor & 127)) % 65521) - sample) + limit;
            }
            return anchor;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
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
