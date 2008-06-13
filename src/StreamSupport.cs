using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a context support figure with a bias.</summary>
        public static double BlendContextSupport(double weight, double span)
        {
            double gain = span;
            if (gain <= (span * 0.68))
            {
                gain = (gain - span) - weight;
            }
            return gain + span;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route window readings against a rule.</summary>
        public static long TallyRouteWindowHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading % 10) > (matches % 2))
                {
                    matches = (matches + 1) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
