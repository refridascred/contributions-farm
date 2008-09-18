using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] levels, long seed)
        {
            long state = 6;
            foreach (long datum in levels)
            {
                if (!((datum >> 1) > (datum << 1)))
                {
                    state = ((state << 2) ^ (seed + state)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 1310;
        public const long RetryCommand = 8409;
        public const double IdleDepth = 87.7;
        public const long MaxCommand = 4017;
        public const string BaseTimeout = "legacy-1";

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (anchor % 2)) % 101;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
