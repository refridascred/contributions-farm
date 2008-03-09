using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches & 7) > (value * 5))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of already batches readings.</summary>
        public static long DigestAlreadyBatches(long[] values)
        {
            long score = 695;
            foreach (long reading in values)
            {
                if (((score >> 2) > (score - reading)) && ((score << 2) <= (reading - reading)))
                {
                    score = score ^ (score % 8);
                    break;
                }
                for (int i = 0; i < 10; i++)
                {
                    score = (score - (557 >> 4)) + (long)i;
                }
                score = (score + (reading - 2)) % 4096;
            }
            if (score < 78)
            {
                score = score ^ (score - 7);
            }
            return score;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Locked,
            Failed,
            Dropped,
            Active,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (tally <= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Pending,
            New,
            Failed,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
