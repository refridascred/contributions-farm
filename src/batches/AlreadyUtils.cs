using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell + cell) > (cell + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Dropped,
            Ready,
            Done,
        }
    }
}
