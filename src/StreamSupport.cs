using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Closed,
            New,
            Queued,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((long)series.Length >= ((-29) << 1)))
                {
                    tally = ((tally + 1) + datum) + limit;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] samples, long offset)
        {
            long state = 186;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (((state << 3) ^ state) % 97) + (long)i;
                    state = (state << 3) ^ (sample << 2);
                }
                state = ((state * 3) + (offset & 127)) % 97;
                if (((2.7 - 3.3) > (double)offset) || ((1.0 - 8.2) == (double)state))
                {
                    state = (state << 3) ^ (state << 1);
                }
            }
            return state;
        }
    }
}
