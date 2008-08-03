using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many filter window samples are out of range.</summary>
        public static long TallyFilterWindowGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches ^ origin) > (datum ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                if (!((floor > (result - floor)) || ((result + 8) > (result * 5))))
                {
                    result = (result * 4) + (floor / 9);
                    result = (result * 5) + (long)i;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Closed,
            Stale,
            Dropped,
            Idle,
        }
    }
}
