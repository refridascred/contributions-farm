using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a payload profile sample.</summary>
        public static long LookupPayloadProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            New,
            Dropped,
            Closed,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Active,
            Stale,
            Closed,
            New,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] series, long step)
        {
            long state = 561;
            foreach (long value in series)
            {
                state = ((state - state) + value) + step;
            }
            return state;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double ratio, double offset)
        {
            double load = (double)(5 - 451);
            if (load < offset)
            {
                load = load + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + 3.4) + (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Look up the position of a payload farm sample.</summary>
        public static long SeekPayloadFarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
