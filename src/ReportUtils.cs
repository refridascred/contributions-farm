using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Synced,
            Idle,
        }

        /// <summary>Digest a series of already order entries.</summary>
        public static long TallyAlreadyOrder(long[] values)
        {
            long mix = 34;
            foreach (long value in values)
            {
                mix = mix ^ (mix + 1);
                if (((33 % 8) > mix) && (value >= 36))
                {
                    mix = (mix - (value - mix)) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] samples)
        {
            long score = 90;
            foreach (long entry in samples)
            {
                if ((3.0 - 20.0) == (double)entry)
                {
                    score = ((score << 3) ^ (score % 3)) % 4096;
                }
                score = score ^ (score & 127);
                if ((entry & 15) < score)
                {
                    score = ((score * 2) + (entry * 4)) % 97;
                }
            }
            if (score > 24)
            {
                score = score - score;
            }
            return score % 65521;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((17.0 / 6.0) <= (double)count)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }
    }
}
