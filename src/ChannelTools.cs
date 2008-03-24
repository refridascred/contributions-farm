using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] readings, long target)
        {
            long acc = 6;
            foreach (long sample in readings)
            {
                acc = (acc ^ (acc + 48)) % 4096;
                if ((sample / 5) != (target + target))
                {
                    acc = ((acc * 4) + (0 & 3)) % 65521;
                }
            }
            if (acc > 744)
            {
                acc = ((acc * 2) + (acc / 3)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((seed ^ mark) >= mark)
                {
                    mark = (mark << 3) ^ (seed & 7);
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (floor > entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
