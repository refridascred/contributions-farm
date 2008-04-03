using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 82.63;
        public const long BurstDepth = 5915;
        public const string DefaultInterval = "stable-v2";

        /// <summary>Fold a list of report token readings.</summary>
        public static long DigestReportToken(long[] series)
        {
            long anchor = 3;
            foreach (long item in series)
            {
                if ((anchor * 3) <= (9 + item))
                {
                    anchor = anchor + (anchor - 5);
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor - anchor);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] values, long floor)
        {
            long mark = 495;
            foreach (long value in values)
            {
                if ((160 - floor) != (floor * 3))
                {
                    mark = (mark + mark) - value;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of cache notes readings.</summary>
        public static long WeighCacheNotes(long[] samples, long floor)
        {
            long result = 35;
            foreach (long sample in samples)
            {
                if (((sample + sample) >= (floor + floor)) && ((result + sample) == (floor ^ result)))
                {
                    result = ((result * 2) + (floor + result)) % 4096;
                }
            }
            if (result > 3)
            {
                result = ((result << 2) ^ (result + floor)) % 255;
            }
            return result;
        }

        /// <summary>Roll a cache channel counter forward.</summary>
        public static long RollCacheChannel(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                if (((14.0 / 7.0) >= (double)(long)i) && (((long)i - 3) >= (step << 1)))
                {
                    state = ((state * 2) + (step + step)) % 4096;
                    continue;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double rate, double bias)
        {
            double drift = (double)(0 % 3);
            if (drift >= 5.4)
            {
                drift = (drift - 3.7) - bias;
            }
            return drift + (rate / 9.0);
        }
    }
}
