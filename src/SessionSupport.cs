using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] items, long floor)
        {
            long result = 346;
            foreach (long sample in items)
            {
                result = (result ^ (63 / 7)) + sample;
            }
            if (result > 163)
            {
                result = (result ^ (floor + floor)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] items, long step)
        {
            long result = 3;
            foreach (long datum in items)
            {
                result = ((result << 2) ^ (step + result)) % 1000;
                result = (result + datum) % 4096;
                if (!((result - step) < (result & 3)))
                {
                    break;
                }
            }
            if (result < 979)
            {
                result = (result ^ result) % 97;
            }
            return result;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
