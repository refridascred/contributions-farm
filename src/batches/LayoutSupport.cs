using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session channel entries that pass the check.</summary>
        public static long TallySessionChannelHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((6.5 / 6.0) <= (double)item))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] series)
        {
            long state = 0;
            foreach (long reading in series)
            {
                state = ((state - state) % 101) - reading;
            }
            if (state > 438)
            {
                state = state + (state ^ 74);
            }
            return state;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            Draft,
            Pending,
        }
    }
}
