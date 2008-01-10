using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate order window readings against a bound.</summary>
        public static bool GuardOrderWindowRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen * 3) >= (seen % 24))
                {
                    seen = ((seen + 3) + sample) - offset;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] series, long bound)
        {
            long total = 8;
            foreach (long sample in series)
            {
                total = ((total - (total + sample)) % 97) + bound;
            }
            if (total > 23)
            {
                total = total + (total * 4);
            }
            return total % 65521;
        }
    }
}
