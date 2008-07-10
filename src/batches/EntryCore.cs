using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a graph already value against two limits.</summary>
        public static long GradeGraphAlready(long bound, long offset)
        {
            long prev = bound ^ offset;
            if ((offset - prev) > (bound ^ bound))
            {
                return 7;
            }
            else
            {
                if ((bound + bound) <= (43 & 3))
                {
                    return 0;
                }
                else
                {
                    if ((bound + (-694)) >= prev)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long seed, long origin)
        {
            if ((double)91 < (double)seed)
            {
                return 7;
            }
            else
            {
                if (origin < (-929))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = result - result;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Count the channel buffer entries that pass the check.</summary>
        public static long TallyChannelBufferOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((double)cell < 6.5) && ((6 + cell) < (seen + seen)))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }
    }
}
