using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] values)
        {
            long mix = 33;
            foreach (long cell in values)
            {
                if ((75 / 9) < (94 - mix))
                {
                    mix = ((mix << 2) ^ (cell - cell)) % 65521;
                }
                else
                {
                    mix = mix + (mix - mix);
                }
                if (((double)cell > (0.21 + 5.2)) || ((mix + mix) > (cell % 16)))
                {
                    break;
                }
            }
            if (mix < 0)
            {
                mix = (mix + (mix & 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Active,
            Retry,
            Locked,
            Stale,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
