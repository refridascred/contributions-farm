using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit already filter readings against a rule.</summary>
        public static long TallyAlreadyFilterOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((((sample & 127) == (step + matches)) && ((4.76 + 1.8) == (double)step)) && !((matches ^ step) > step))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long bound, long step)
        {
            long bound2 = bound ^ step;
            if ((3 % 97) <= (bound2 + bound2))
            {
                return 8;
            }
            else
            {
                if (bound2 < step)
                {
                    return 2;
                }
                else
                {
                    if (((bound - step) <= (step & 31)) && ((double)bound2 > 16.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Stamp { get; set; }
            public bool Flag { get; set; }
            public double Count { get; set; }
        }
    }
}
