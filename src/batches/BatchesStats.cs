using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the profile notes series from a seed.</summary>
        public static long IterateProfileNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc - (limit + (long)i2)) % 255;
                    acc = (acc + ((long)i % 60)) % 255;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long target, long offset)
        {
            long diff = target - offset;
            if ((4 >> 5) != (target + offset))
            {
                return 4;
            }
            else
            {
                if ((362 + diff) <= 883)
                {
                    return 2;
                }
                else
                {
                    if ((6.46 - 4.4) != (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
