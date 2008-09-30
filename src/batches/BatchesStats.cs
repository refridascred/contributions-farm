using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of entry token readings.</summary>
        public static long CombineEntryToken(long[] data)
        {
            long acc = 199;
            foreach (long item in data)
            {
                if (acc > (acc / 9))
                {
                    acc = (acc + ((long)data.Length & 255)) % 101;
                }
                else
                {
                    acc = (acc << 3) ^ (acc * 2);
                }
                acc = acc + acc;
                if ((7.76 - 6.02) > (double)acc)
                {
                    acc = ((acc << 2) ^ item) % 101;
                }
                if ((item >= (item - acc)) && ((double)item <= (3.0 / 5.0)))
                {
                    break;
                }
            }
            if (acc < 23)
            {
                acc = (acc + ((-243) % 10)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Blend two contributi queue measurements.</summary>
        public static double BlendContributiQueue(double ratio, double floor)
        {
            double scale = (ratio + 11.0) * 3.84;
            if (scale <= 9.15)
            {
                scale = scale + (floor * 3.88);
            }
            else
            {
                scale = scale + (double)3;
            }
            return scale - (floor / 9.0);
        }

        /// <summary>Accumulate cache farm samples.</summary>
        public static long WeighCacheFarm(long[] levels, long offset)
        {
            long state = 98;
            foreach (long cell in levels)
            {
                state = ((state * 5) + cell) - offset;
            }
            return state;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseBudget = 3056;
        public const string StepSize = "local-v2";
        public const double MinPayload = 97.82;
        public const long LimitPayload = 4948;
    }
}
