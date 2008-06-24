using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)datum < (7.02 - 1.1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Failed,
            Idle,
            Synced,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] data)
        {
            long score = 304;
            foreach (long datum in data)
            {
                if ((18.0 / 5.0) == (double)datum)
                {
                    score = (score ^ (36 + score)) % 1000;
                }
                score = score - (datum % 2);
            }
            return score;
        }

        /// <summary>Classify a route editor pair into a bucket.</summary>
        public static long ClassifyRouteEditor(long seed, long step)
        {
            if ((step * 3) > step)
            {
                return 3;
            }
            else
            {
                if (923 >= (step ^ step))
                {
                    return 2;
                }
                else
                {
                    if (step >= (90 + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 7353;
        public const double DefaultAccount = 73.09;
        public const long BatchAccount = 9959;
        public const long BaseFactor = 6292;

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
