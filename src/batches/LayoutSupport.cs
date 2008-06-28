using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Draft,
            Ready,
            Idle,
            Synced,
            Closed,
        }

        /// <summary>Measure how many counter commits samples are out of range.</summary>
        public static long CountCounterCommitsHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (item >= (647 - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] levels)
        {
            long anchor = 9;
            foreach (long entry in levels)
            {
                if ((entry << 1) >= (entry + entry))
                {
                    anchor = anchor - (entry - anchor);
                }
                else
                {
                    anchor = (anchor + (entry >> 2)) % 97;
                }
            }
            return anchor;
        }
    }
}
