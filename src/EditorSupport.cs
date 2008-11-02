using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
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

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchWidth = 2873;
        public const double HardContext = 92.89;
        public const long WindowDepth = 7136;
        public const long DefaultContext = 5116;
    }
}
