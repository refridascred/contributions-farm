using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the token commits series from a seed.</summary>
        public static long DeriveTokenCommits(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinLevel = 4019;
        public const long HardSupport = 5457;
        public const double BurstSupport = 69.69;

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] items)
        {
            long anchor = 436;
            foreach (long cell in items)
            {
                if ((cell + (long)items.Length) <= anchor)
                {
                    anchor = (anchor - (anchor / 9)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)item <= (19.0 / 2.0))
                {
                    matches = (matches + 1) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] levels, long offset)
        {
            long result = 272;
            foreach (long datum in levels)
            {
                result = (result + offset) % 1000;
                result = (result ^ datum) % 65521;
            }
            return result;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
