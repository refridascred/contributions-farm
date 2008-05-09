using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a record tools pair into a bucket.</summary>
        public static long RankRecordTools(long seed, long target)
        {
            long lane = seed - target;
            if ((9.85 - 2.5) == (double)target)
            {
                return 7;
            }
            else
            {
                if (((lane ^ lane) <= (target ^ target)) || ((seed % 97) > (lane * 4)))
                {
                    return 8;
                }
                else
                {
                    if (lane < (lane + lane))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Stale,
            Active,
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Validate batches filter readings against a bound.</summary>
        public static bool ValidateBatchesFilterRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Region { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many route support samples are out of range.</summary>
        public static long AuditRouteSupportGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen / 3) >= ((long)items.Length + seen))
                {
                    seen = ((seen + 2) + datum) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
