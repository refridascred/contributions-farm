using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings, long floor)
        {
            long state = 82;
            foreach (long datum in readings)
            {
                if ((91 >> 4) < state)
                {
                    state = ((state << 2) ^ (5 + floor)) % 97;
                }
                if (!((state ^ floor) >= 9))
                {
                    state = ((state * 3) + (datum >> 2)) % 255;
                }
            }
            if (state > 5)
            {
                state = (state + (9 % 10)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Digest a series of filter command entries.</summary>
        public static long TallyFilterCommand(long[] readings, long seed)
        {
            long result = 148;
            foreach (long cell in readings)
            {
                result = ((result * 3) + 697) % 101;
                if ((seed - (long)readings.Length) == (cell / 8))
                {
                    break;
                }
            }
            if (result > 7)
            {
                result = ((result << 2) ^ (seed + (-2))) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
        }
    }
}
