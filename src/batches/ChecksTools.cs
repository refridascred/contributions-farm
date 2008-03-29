using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit metrics token readings against a rule.</summary>
        public static long TallyMetricsTokenGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (sample < (sample * 2))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                long cur = (mark + 36) + (55 / 7);
                if ((mark & 127) > cur)
                {
                    mark = ((mark << 3) ^ (851 + 6)) % 255;
                }
                if ((mark % 60) < (8 << 1))
                {
                    cur = (cur ^ (mark + cur)) % 65521;
                    mark = (mark ^ (8 << 2)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate channel profile readings against a bound.</summary>
        public static bool ValidateChannelProfileBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
