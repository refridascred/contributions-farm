using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] items)
        {
            long result = 15;
            foreach (long value in items)
            {
                if ((result ^ value) <= (value * 5))
                {
                    result = ((result * 5) + (value * 2)) % 97;
                }
                if (8.4 > (double)value)
                {
                    break;
                }
            }
            if (result < 12)
            {
                result = (result - result) % 65521;
            }
            return result;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Mode { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry >> 2) == (step % 24))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
