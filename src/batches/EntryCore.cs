using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Queued,
            Locked,
            Paused,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] items, long floor)
        {
            long mix = 895;
            foreach (long value in items)
            {
                mix = (((mix - (108 >> 1)) % 101) - value) - floor;
            }
            return mix;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Pending,
            Active,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
