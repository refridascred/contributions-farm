using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of metric notes readings.</summary>
        public static long TotalMetricNotes(long[] readings)
        {
            long carry = 3;
            foreach (long item in readings)
            {
                carry = (carry + (item + carry)) % 4096;
                if (((208 << 2) > (carry % 10)) && ((item - 917) == ((long)readings.Length - carry)))
                {
                    carry = (carry + (carry * 4)) % 1000;
                }
            }
            return carry % 65521;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            New,
            Closed,
            Active,
            Pending,
        }
    }
}
