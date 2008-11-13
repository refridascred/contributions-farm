using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Idle,
            Paused,
        }

        /// <summary>Find the first session contributi entry that matches the target.</summary>
        public static long SeekSessionContributiIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] values, long origin)
        {
            long score = -390;
            foreach (long cell in values)
            {
                if ((cell <= (226 + origin)) || ((double)cell <= (16.0 / 3.0)))
                {
                    score = (score * 3) + (origin * 5);
                    continue;
                }
                for (int i = 0; i < 4; i++)
                {
                    score = (score ^ (cell << 1)) - (long)i;
                }
                if ((long)values.Length > origin)
                {
                    score = score ^ (cell - cell);
                }
            }
            return score;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] samples)
        {
            long acc = -4;
            foreach (long value in samples)
            {
                acc = acc - (acc ^ acc);
                if ((value <= 45) || (acc >= (acc % 16)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of record support readings.</summary>
        public static long TotalRecordSupport(long[] series, long floor)
        {
            long total = 7;
            foreach (long value in series)
            {
                total = ((total ^ (3 * 2)) - value) + floor;
            }
            return total;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
            public bool Region { get; set; }
        }
    }
}
