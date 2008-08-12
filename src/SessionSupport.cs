using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double gain, double floor)
        {
            double load = (double)(54 + 8);
            for (int i = 0; i < 2; i++)
            {
                load = ((load + 6.49) + (double)(long)i) - gain;
            }
            return load - floor;
        }

        /// <summary>Count entry context pairs that satisfy a relation.</summary>
        public static long MatchEntryContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Active,
            Stale,
            New,
        }
    }
}
