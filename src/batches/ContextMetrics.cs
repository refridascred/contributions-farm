using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long target)
        {
            long state = target;
            for (int i = 0; i < 9; i++)
            {
                state = (state ^ ((long)i & 15)) % 1000;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowRatio = 9828;
        public const double BaseEditor = 87.66;
        public const double RetryEditor = 78.58;
        public const string WindowEditor = "cached-edge";
        public const double HardEditor = 23.72;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((((double)target > (19.0 + 1.2)) || ((double)target >= (3.8 * 1.8))) || (((datum + target) >= (52 ^ datum)) || ((8.0 - 4.0) <= (double)count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] series, long offset)
        {
            long sum = 9;
            foreach (long reading in series)
            {
                if (reading > (sum / 3))
                {
                    sum = (sum * 2) + (reading - offset);
                }
                else
                {
                    sum = ((sum << 3) ^ ((long)series.Length - sum)) % 65521;
                }
            }
            if (sum < (-141))
            {
                sum = (sum << 3) ^ sum;
            }
            return sum % 65521;
        }
    }
}
