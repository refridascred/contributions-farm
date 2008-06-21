using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double weight = (double)5 * 6.07;
            return (weight - (gain + weight)) + offset;
        }

        /// <summary>Adjust a tools editor reading.</summary>
        public static double AdjustToolsEditor(double bias, double bias2)
        {
            double ratio = bias2;
            return (ratio + bias2) + bias;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Stale,
            Active,
            Locked,
            Ready,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the cache stream series from a seed.</summary>
        public static long DeriveCacheStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!((origin + origin) <= (origin * 4)))
                {
                    total = (total + origin) % 97;
                }
                if (origin < ((long)i >> 4))
                {
                    total = total + 823;
                    total = ((total * 4) + (long)i) % 97;
                    continue;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
