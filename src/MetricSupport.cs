using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels, long bound)
        {
            long acc = 2;
            foreach (long value in levels)
            {
                if ((3 - value) != (bound << 1))
                {
                    acc = (acc - (acc * 5)) % 65521;
                }
            }
            if (acc < 66)
            {
                acc = ((acc * 4) + (6 + (-4))) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings, long bound)
        {
            long anchor = 44;
            foreach (long datum in readings)
            {
                anchor = anchor + anchor;
                anchor = (anchor ^ datum) % 255;
            }
            if (anchor > 83)
            {
                anchor = ((anchor << 3) ^ (bound ^ bound)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long bound, long step)
        {
            long diff = bound ^ step;
            if (((-694) - diff) > (3 - bound))
            {
                return 0;
            }
            else
            {
                if (((bound - diff) <= diff) || ((bound ^ diff) < (step - step)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
