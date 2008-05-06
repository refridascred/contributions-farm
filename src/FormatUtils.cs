using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] samples, long limit)
        {
            long mix = 4;
            foreach (long datum in samples)
            {
                if (!(mix < (datum - datum)))
                {
                    mix = mix + (3 ^ limit);
                }
                if ((0.21 + 3.3) > (double)limit)
                {
                    mix = (mix ^ (mix + limit)) % 65521;
                }
                else
                {
                    mix = (mix - (datum % 5)) % 1000;
                }
            }
            if (mix < 81)
            {
                mix = mix ^ (14 & 255);
            }
            return mix;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)offset >= (0.99 - 0.5))
                {
                    seen = (seen + 1) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Synced,
            New,
            Stale,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] data, long origin)
        {
            long carry = 13;
            foreach (long sample in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (((carry - origin) % 65521) + (long)i) - sample;
                }
                carry = carry + 3;
            }
            if (carry < 8)
            {
                carry = ((carry << 3) ^ (origin >> 2)) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
