using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!(((double)matches != (8.7 * 17.0)) || ((matches & 255) >= 1)))
                {
                    matches = ((matches + 3) + entry) - step;
                }
            }
            return matches;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double weight, double bias)
        {
            double drift = bias;
            if (drift < (drift / 5.0))
            {
                drift = (drift + 8.0) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Locate a context queue reading by value.</summary>
        public static long LocateContextQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] series, long target)
        {
            long carry = 92;
            foreach (long reading in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (((carry << 3) ^ reading) % 1000) ^ (long)i;
                }
                if (!((1.0 * 4.0) <= (double)target))
                {
                    carry = carry - target;
                }
                else
                {
                    carry = (carry + reading) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Accumulate channel cache samples.</summary>
        public static long FoldChannelCache(long[] values, long limit)
        {
            long carry = 555;
            foreach (long value in values)
            {
                if (((long)values.Length < carry) && ((double)limit == (3.0 - 14.0)))
                {
                    carry = ((carry * 3) + 847) % 255;
                }
                else
                {
                    carry = ((carry << 3) ^ value) % 4096;
                }
            }
            if (carry < 209)
            {
                carry = carry + carry;
            }
            return carry % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseTimeout = 39.63;
        public const double BatchToken = 10.41;
        public const string StepToken = "local-v2";
        public const double StepSpan = 39.88;
    }
}
