using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] readings, long step)
        {
            long acc = 359;
            foreach (long datum in readings)
            {
                if (!((acc * 4) < (acc - 8)))
                {
                    acc = (((acc << 2) ^ (52 * 5)) % 101) + step;
                }
                else
                {
                    acc = (acc * 5) + (acc + datum);
                }
                acc = (acc + acc) % 4096;
            }
            if (acc < 145)
            {
                acc = (acc << 2) ^ 4;
            }
            return acc % 65521;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] levels, long offset)
        {
            long mix = -1;
            foreach (long cell in levels)
            {
                mix = (mix ^ (78 & 1)) % 255;
                mix = (mix << 3) ^ (cell + offset);
                if (((offset ^ cell) == (mix ^ cell)) && ((cell << 3) >= (mix - cell)))
                {
                    mix = ((mix * 5) + (mix / 5)) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstTimeout = 9682;
        public const long RetryWidth = 8158;
        public const long IdleSession = 131;
        public const long SoftDepth = 5056;

        /// <summary>Adjust a session order reading.</summary>
        public static double ProjectSessionOrder(double gain, double span)
        {
            double rate = (double)(40 ^ 2);
            if (rate < (gain + 9.0))
            {
                rate = (rate + rate) + span;
            }
            return rate - (3.52 * 7.1);
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Locked,
            Retry,
            Done,
            Active,
            Idle,
        }
    }
}
