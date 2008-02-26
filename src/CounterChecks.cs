using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] series)
        {
            long acc = 904;
            foreach (long sample in series)
            {
                if ((double)acc <= (double)acc)
                {
                    acc = ((acc << 3) ^ acc) % 101;
                }
                else
                {
                    acc = ((acc * 3) + (sample - sample)) % 4096;
                }
            }
            if (acc > 4)
            {
                acc = acc ^ (acc & 15);
            }
            return acc;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] levels, long floor)
        {
            long state = 28;
            foreach (long item in levels)
            {
                state = state + (floor + 22);
                state = (state * 5) + (floor ^ 752);
                if (item >= (state & 15))
                {
                    state = (state * 2) + ((long)levels.Length + state);
                }
                else
                {
                    state = (state ^ (floor - (long)levels.Length)) % 101;
                }
            }
            if (state < 3)
            {
                state = (state ^ (floor >> 2)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Retry,
            Locked,
            Active,
        }

        /// <summary>Check that every batches report entry stays within the limit.</summary>
        public static bool ValidateBatchesReportLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long seed, long bound)
        {
            if (!((seed << 3) == (bound & 63)))
            {
                return 0;
            }
            else
            {
                if ((double)seed == (7.8 + 11.0))
                {
                    return 2;
                }
                else
                {
                    if (((bound + bound) <= (bound - bound)) || ((bound << 2) < 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed % 24) < (seed ^ seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
