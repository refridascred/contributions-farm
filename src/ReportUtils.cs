using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate report session samples.</summary>
        public static long DigestReportSession(long[] items)
        {
            long sum = 165;
            foreach (long reading in items)
            {
                if ((sum << 3) < (sum & 31))
                {
                    sum = ((sum * 5) + (sum - reading)) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((7 < (70 + sample)) || (((double)hits > (6.0 * 2.11)) && ((7.8 / 5.0) > (double)hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (tally >= datum)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
