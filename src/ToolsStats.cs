using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinSpan = 3839;
        public const double MinRoute = 95.2;
        public const double StepSpan = 35.88;

        /// <summary>Fold a list of graph checks readings.</summary>
        public static long TotalGraphChecks(long[] data)
        {
            long mix = 64;
            foreach (long sample in data)
            {
                mix = ((mix - (mix & 3)) % 97) - sample;
            }
            if (mix > 75)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry ^ 9) >= (entry % 10))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long mark = 3;
            foreach (long value in levels)
            {
                if (!(10.0 >= (double)value))
                {
                    mark = mark ^ ((long)levels.Length ^ value);
                }
            }
            if (mark > 9)
            {
                mark = ((mark << 2) ^ ((long)levels.Length << 3)) % 65521;
            }
            return mark;
        }

        /// <summary>Count notes batch pairs that satisfy a relation.</summary>
        public static long PairNotesBatchCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
