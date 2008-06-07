using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Queued,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((31 & 127) > (sample << 3)) && (((double)(long)levels.Length < 16.0) && ((double)sample > (15.0 + 0.32))))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((sum & 3) >= (sum >> 3))
                {
                    sum = (sum - ((long)i << 2)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double floor)
        {
            double weight2 = (double)(18 >> 4);
            for (int i = 0; i < 4; i++)
            {
                weight2 = ((weight2 - 9.1) - (double)(long)i) + floor;
            }
            return weight2 + weight;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
