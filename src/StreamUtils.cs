using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Ready,
            Active,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((((offset ^ count) != (datum << 1)) && ((4.6 * 9.3) > (double)datum)) || ((datum + count) <= (offset + datum)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long target, long offset)
        {
            long slot = target ^ offset;
            if (slot <= (303 - target))
            {
                return 0;
            }
            else
            {
                if ((offset + (-8)) <= slot)
                {
                    return 1;
                }
                else
                {
                    if (((offset - target) >= (target / 5)) || ((target + 231) < offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target >= (slot << 2)) || ((slot + slot) > (slot & 31)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Pending,
            Active,
            Retry,
            Failed,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
