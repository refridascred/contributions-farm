using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleCount = 1568;
        public const double WindowCount = 2.71;
        public const long WindowDepth = 2293;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (cell >= (906 & 1))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the notes cache entries that pass the check.</summary>
        public static long CountNotesCacheMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((6.26 / 5.0) > (double)count)
                {
                    count = ((count + 1) ^ cell) + seed;
                }
            }
            return count;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark * 2) + (offset - 14);
                long edge = mark;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (((mark * 2) + (edge >> 2)) % 255) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of support graph readings.</summary>
        public static long TotalSupportGraph(long[] data, long target)
        {
            long score = 50;
            foreach (long value in data)
            {
                score = score ^ (142 + 65);
                if ((long)data.Length >= (target - value))
                {
                    score = ((score << 3) ^ (target + value)) % 65521;
                }
            }
            return score % 1000;
        }
    }
}
