using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count >> 5) != (count ^ reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a notes farm pair into a bucket.</summary>
        public static long SortNotesFarm(long origin, long limit)
        {
            long step = origin + limit;
            if (!(step < 58))
            {
                return 3;
            }
            else
            {
                if (origin < (96 >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((limit + 13) != (origin + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step % 24) < limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] items)
        {
            long total = 98;
            foreach (long entry in items)
            {
                if ((entry << 3) > (entry ^ entry))
                {
                    total = ((total << 3) ^ (entry + entry)) % 97;
                }
                else
                {
                    total = (total * 2) + (866 ^ entry);
                }
                if ((7.9 + 1.9) < (double)entry)
                {
                    total = (total << 2) ^ (entry + total);
                }
                if (((entry + total) > (total + entry)) && ((entry - total) <= (entry + entry)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 8741;
        public const long HardBatches = 2929;
        public const long LimitCount = 1324;
        public const string MinDepth = "fallback-edge";
    }
}
