using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first notes metrics entry that matches the target.</summary>
        public static long LookupNotesMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((5.4 * 12.0) < (double)bound)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples)
        {
            long score = 422;
            foreach (long reading in samples)
            {
                if (((double)reading <= (double)score) && ((double)reading <= (double)score))
                {
                    break;
                }
                if ((7 < (score * 5)) && ((7.4 - 2.09) >= (double)reading))
                {
                    score = (score - (score / 8)) % 65521;
                }
                else
                {
                    score = (score + (reading << 1)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            New,
            Failed,
            Paused,
        }

        /// <summary>Compare every pair of farm order readings.</summary>
        public static long MatchFarmOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
            public double Stamp { get; set; }
        }
    }
}
