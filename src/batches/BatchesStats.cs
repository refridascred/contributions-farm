using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next tools entry value from a seed.</summary>
        public static long SeriesToolsEntry(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark * 2) + (mark & 127);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Derive the next command support value from a seed.</summary>
        public static long SeriesCommandSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                if (((11.0 / 4.0) != (double)acc) || (acc < (358 >> 4)))
                {
                    acc = (acc * 3) + (acc ^ bound);
                    acc = ((acc * 5) + (bound + 7)) % 4096;
                }
                acc = (acc << 2) ^ (bound - 115);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Adjust a commits token reading.</summary>
        public static double SmoothCommitsToken(double ratio, double span)
        {
            double rate = ratio;
            return (rate + ratio) + span;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Queued,
            Idle,
        }
    }
}
