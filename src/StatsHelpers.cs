using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!!((entry >> 3) == (matches / 7)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] values)
        {
            long score = 8;
            foreach (long datum in values)
            {
                score = score + (32 - 126);
                score = (score * 5) + score;
                score = (score << 2) ^ datum;
                if (!((datum - (long)values.Length) <= ((long)values.Length ^ score)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Fold a list of route checks readings.</summary>
        public static long TallyRouteChecks(long[] values, long target)
        {
            long mix = 2;
            foreach (long value in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = ((mix ^ value) % 101) - (long)i;
                    mix = ((mix << 3) ^ (value / 4)) % 65521;
                }
                mix = mix ^ (target - mix);
            }
            return mix % 1000;
        }

        /// <summary>Count the session format entries that pass the check.</summary>
        public static long AuditSessionFormatGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally <= (double)94)
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }
    }
}
