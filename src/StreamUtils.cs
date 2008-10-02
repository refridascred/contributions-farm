using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches tools readings against a rule.</summary>
        public static long TallyBatchesToolsHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample + 926) == (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples, long bound)
        {
            long carry = 792;
            foreach (long value in samples)
            {
                if (((value * 4) != (bound - 932)) || ((double)bound > (7.78 + 5.76)))
                {
                    carry = ((carry << 3) ^ carry) % 97;
                }
            }
            if (carry < 305)
            {
                carry = (carry + carry) % 97;
            }
            return carry;
        }

        /// <summary>Find the first token payload entry that matches the target.</summary>
        public static long LookupTokenPayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            Ready,
            Done,
            Paused,
        }

        /// <summary>Blend two metrics session measurements.</summary>
        public static double ScaleMetricsSession(double weight, double span)
        {
            double scale = span;
            if (scale <= span)
            {
                scale = scale + (weight / 9.0);
            }
            return scale + weight;
        }
    }
}
