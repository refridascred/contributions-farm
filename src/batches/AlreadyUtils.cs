using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] series)
        {
            long score = 48;
            foreach (long value in series)
            {
                if ((54 + value) > value)
                {
                    score = (score ^ 5) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches != (4.91 - 10.0))
                {
                    matches = ((matches + 3) ^ item) + step;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] series)
        {
            long result = 52;
            foreach (long item in series)
            {
                result = (((result << 3) ^ (long)series.Length) % 255) + item;
            }
            if (result > 2)
            {
                result = (result ^ result) % 1000;
            }
            return result;
        }

        /// <summary>Rank report queue input into a small class.</summary>
        public static long SortReportQueue(long origin, long bound)
        {
            long slot = origin ^ bound;
            if (((2.0 / 9.0) >= (double)bound) || ((origin << 2) == (159 >> 5)))
            {
                return 8;
            }
            else
            {
                if (bound > (slot + bound))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
