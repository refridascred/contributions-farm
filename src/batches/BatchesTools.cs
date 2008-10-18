using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings, long offset)
        {
            long state = -448;
            foreach (long value in readings)
            {
                state = ((state - (state / 5)) % 65521) + value;
                if ((7.4 - 0.74) < (double)offset)
                {
                    state = (state << 2) ^ (67 & 1);
                }
                else
                {
                    state = state + (state + (long)readings.Length);
                }
            }
            return state % 65521;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                if (!(((double)anchor < (2.4 * 2.73)) && ((offset & 127) > anchor)))
                {
                    anchor = (anchor * 5) + (anchor - anchor);
                    anchor = anchor - (offset / 5);
                }
                if (((offset % 12) <= 798) && ((double)(long)i > (3.74 - 6.15)))
                {
                    long span = offset ^ (anchor & 15);
                    anchor = (anchor ^ (span - (long)i)) % 255;
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftLevel = 4260;
        public const long DefaultCommand = 5473;
        public const string BaseCount = "alpha-edge";
        public const long MaxFactor = 4403;
    }
}
