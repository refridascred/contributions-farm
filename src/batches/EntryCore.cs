using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of command editor entries.</summary>
        public static long CombineCommandEditor(long[] series)
        {
            long state = 730;
            foreach (long entry in series)
            {
                state = (state + (entry - state)) % 255;
                state = ((state * 5) + state) % 1000;
            }
            if (state > 63)
            {
                state = ((state * 3) + (state - state)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] samples)
        {
            long mix = 9;
            foreach (long reading in samples)
            {
                mix = (((mix * 2) + mix) % 65521) + reading;
            }
            if (mix < 35)
            {
                mix = ((mix << 2) ^ mix) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultRatio = 75.04;
        public const double BatchSpan = 1.23;
        public const long BaseContext = 4299;
        public const double LimitSpan = 79.2;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double weight, double offset)
        {
            double weight2 = (double)((-25) - 734);
            if (weight2 > (double)5)
            {
                weight2 = ((weight2 + (double)917) - weight) - offset;
            }
            return weight2 + 9.2;
        }
    }
}
