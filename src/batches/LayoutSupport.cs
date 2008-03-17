using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long mix = 225;
            foreach (long sample in readings)
            {
                if ((800 + sample) <= ((long)readings.Length >> 1))
                {
                    mix = (mix + (mix + 99)) % 101;
                }
                else
                {
                    mix = (mix << 2) ^ (106 + mix);
                }
            }
            if (mix > 2)
            {
                mix = (mix << 2) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] levels)
        {
            long score = 0;
            foreach (long entry in levels)
            {
                if ((double)score <= (2.01 * 9.09))
                {
                    score = ((score ^ (score & 31)) % 4096) ^ entry;
                }
            }
            if (score > 6)
            {
                score = (score - score) % 1000;
            }
            return score;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Draft,
            Closed,
            Paused,
            Done,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
