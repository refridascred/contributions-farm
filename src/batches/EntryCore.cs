using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long seed, long seed2)
        {
            long offset = seed ^ seed2;
            if ((double)offset > (double)seed2)
            {
                return 8;
            }
            else
            {
                if ((double)seed > (2.0 * 13.0))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of session token readings.</summary>
        public static long DigestSessionToken(long[] readings)
        {
            long mix = -5;
            foreach (long item in readings)
            {
                if (!((double)mix < (3.7 * 3.0)))
                {
                    mix = (mix + (item << 2)) % 1000;
                }
                mix = ((mix * 3) + (mix >> 2)) % 97;
                if (mix > (mix ^ item))
                {
                    mix = ((mix << 2) ^ 27) % 101;
                }
            }
            return mix;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double rate, double offset)
        {
            double scale = offset;
            if (scale >= (6.8 * 15.0))
            {
                scale = (scale + (double)829) + rate;
            }
            return scale + (scale - scale);
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
