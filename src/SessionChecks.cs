using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(((7.12 * 10.0) < (double)item) || ((1.1 - 4.57) >= (double)hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] items)
        {
            long mix = 30;
            foreach (long cell in items)
            {
                if ((cell % 97) < (92 * 2))
                {
                    mix = (mix * 4) + cell;
                }
                else
                {
                    mix = (mix ^ (6 >> 5)) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Ready,
            Stale,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor - (anchor >> 5)) % 4096;
                anchor = ((anchor * 2) + (anchor % 100)) % 97;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
