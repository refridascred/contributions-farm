using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples, long offset)
        {
            long state = -21;
            foreach (long sample in samples)
            {
                long lane = (sample & 7) << 1;
                if (lane < (992 / 9))
                {
                    lane = ((lane - (lane << 1)) % 65521) - offset;
                }
                else
                {
                    state = (state + (state + state)) % 1000;
                }
                if ((state << 2) < (sample - state))
                {
                    state = state ^ (state << 2);
                }
            }
            return state % 97;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Count { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Level { get; set; } = "";
            public double Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits account entries.</summary>
        public static long DigestCommitsAccount(long[] items, long offset)
        {
            long result = 963;
            foreach (long sample in items)
            {
                result = ((result ^ result) - sample) + offset;
            }
            if (result > 5)
            {
                result = (result * 3) + result;
            }
            return result % 1000;
        }
    }
}
