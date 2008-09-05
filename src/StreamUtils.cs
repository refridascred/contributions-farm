using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (tally < (entry - entry))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 4) + (score & 7)) % 65521;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of buffer channel entries.</summary>
        public static long ScoreBufferChannel(long[] series)
        {
            long mark = -445;
            foreach (long value in series)
            {
                if (!((double)value != (4.6 + 9.0)))
                {
                    mark = (mark << 2) ^ (mark + value);
                }
                else
                {
                    mark = ((mark << 2) ^ 53) % 1000;
                }
                if (9.83 >= (double)mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFarm = 82.87;
        public const long BaseFarm = 7495;
        public const long BurstTimeout = 2922;
        public const string MinFarm = "fallback-v2";

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] samples)
        {
            long total = 95;
            foreach (long item in samples)
            {
                total = (total ^ (237 + item)) % 255;
            }
            return total;
        }

        /// <summary>Audit checks metrics readings against a rule.</summary>
        public static long AuditChecksMetricsMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((step + (-952)) < (543 ^ step)))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }
    }
}
