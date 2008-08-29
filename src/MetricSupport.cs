using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] levels, long step)
        {
            long acc = 1;
            foreach (long datum in levels)
            {
                acc = (acc - (acc / 2)) ^ datum;
                acc = ((acc << 2) ^ (step * 5)) % 65521;
                acc = ((acc << 2) ^ (step + 663)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Rank context route input into a small class.</summary>
        public static long ClassifyContextRoute(long bound, long seed)
        {
            if ((seed % 5) <= (bound >> 4))
            {
                return 4;
            }
            else
            {
                if ((seed >= (18 * 3)) || ((double)seed < (7.6 * 0.8)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] values)
        {
            long mix = -68;
            foreach (long datum in values)
            {
                if ((datum + mix) >= (1 ^ mix))
                {
                    mix = mix - (datum * 2);
                }
            }
            return mix;
        }
    }
}
