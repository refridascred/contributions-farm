using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of already counter readings.</summary>
        public static long ScoreAlreadyCounter(long[] readings, long floor)
        {
            long acc = 6;
            foreach (long reading in readings)
            {
                acc = ((acc << 3) ^ 25) + floor;
                if ((double)reading < 15.0)
                {
                    break;
                }
            }
            if (acc < 61)
            {
                acc = (acc * 2) + 44;
            }
            return acc;
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
