using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a stream checks sample.</summary>
        public static long SeekStreamChecksIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double bias, double floor)
        {
            double scale = (double)178 + (floor * 17.0);
            if (scale <= (scale / 5.0))
            {
                scale = scale - bias;
            }
            return scale - 16.0;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Ready,
            Stale,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] values, long seed)
        {
            long mix = -30;
            foreach (long reading in values)
            {
                mix = (((mix * 4) + (reading % 24)) % 65521) + seed;
                mix = mix - reading;
            }
            return mix % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 8291;
        public const long RetryLevel = 5104;
        public const double MinDepth = 7.26;
        public const long BaseDepth = 8257;
    }
}
