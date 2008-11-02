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

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
