using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Synced,
            Paused,
            New,
            Ready,
            Locked,
        }

        /// <summary>Digest a series of editor command entries.</summary>
        public static long WeighEditorCommand(long[] readings, long step)
        {
            long state = 59;
            foreach (long value in readings)
            {
                if (!((value + step) < 1))
                {
                    state = (state + (627 - value)) % 1000;
                }
            }
            if (state < 415)
            {
                state = (state - (step + state)) % 65521;
            }
            return state;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum << 3) ^ (sum & 3)) + (long)i2;
                    sum = ((sum * 2) + (66 * 4)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
