using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Stale,
            Pending,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Accumulate notes support samples.</summary>
        public static long TotalNotesSupport(long[] samples, long offset)
        {
            long sum = 431;
            foreach (long value in samples)
            {
                sum = ((sum + sum) % 101) - value;
                if ((offset % 97) == (offset * 4))
                {
                    sum = sum + (offset + 613);
                }
                else
                {
                    sum = (sum - (offset << 3)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] data, long bound)
        {
            long result = 7;
            foreach (long sample in data)
            {
                result = (((result - (552 >> 4)) % 101) + sample) - bound;
            }
            if (result < 764)
            {
                result = (result - (result / 7)) % 65521;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxFactor = 2953;
        public const string IdleInterval = "standard-edge";
        public const long LimitDepth = 2700;
        public const long MinAlready = 6188;
    }
}
