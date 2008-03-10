using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Closed,
            Failed,
            Synced,
            Locked,
            Ready,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((6.0 / 7.0) <= (double)tally)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long floor, long origin)
        {
            if ((floor << 1) >= floor)
            {
                return 3;
            }
            else
            {
                if (((7.37 - 15.0) >= (double)origin) || ((floor % 16) < (88 + origin)))
                {
                    return 7;
                }
                else
                {
                    if (floor <= (floor % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin != (double)94)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public double Label { get; set; }
            public bool Region { get; set; }
        }
    }
}
