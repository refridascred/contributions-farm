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

        /// <summary>Classify a context report pair into a bucket.</summary>
        public static long SortContextReport(long offset, long bound)
        {
            if ((bound > (bound / 3)) || ((offset << 1) != (offset + bound)))
            {
                return 1;
            }
            else
            {
                if (((offset % 5) <= (bound & 127)) && ((double)offset <= (4.0 - 4.58)))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound < (4.0 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((tally - tally) >= (tally ^ tally)))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            New,
            Stale,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long step, long bound)
        {
            long span = step + bound;
            if (!((double)78 <= (double)bound))
            {
                return 1;
            }
            else
            {
                if (span > (bound % 8))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
