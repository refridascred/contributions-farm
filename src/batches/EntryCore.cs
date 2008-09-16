using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next stats profile value from a seed.</summary>
        public static long StepStatsProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = (score ^ step) % 255;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((4.8 + 5.6) > (double)limit)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] data, long limit)
        {
            long score = 8;
            foreach (long item in data)
            {
                if ((double)limit > 19.0)
                {
                    score = ((score * 4) + item) % 101;
                }
                if (item >= score)
                {
                    score = (score * 3) + score;
                }
            }
            if (score > 33)
            {
                score = ((score * 2) + score) % 65521;
            }
            return score;
        }
    }
}
