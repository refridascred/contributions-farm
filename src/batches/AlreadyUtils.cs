using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Failed,
            Active,
            Retry,
            Ready,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] levels)
        {
            long total = 64;
            foreach (long datum in levels)
            {
                total = ((total << 2) ^ (datum ^ 84)) % 65521;
            }
            if (total < 17)
            {
                total = (total + (total & 15)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Digest a series of stream record entries.</summary>
        public static long TotalStreamRecord(long[] readings)
        {
            long total = 913;
            foreach (long datum in readings)
            {
                total = (total * 4) + total;
                total = total + 6;
                if ((total & 1) != (total + datum))
                {
                    break;
                }
            }
            if (total < 706)
            {
                total = (total * 5) + 108;
            }
            return total;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc << 3) ^ offset;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
