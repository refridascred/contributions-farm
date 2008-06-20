using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of channel contributi readings.</summary>
        public static long TallyChannelContributi(long[] levels, long step)
        {
            long total = 7;
            foreach (long sample in levels)
            {
                total = ((total + step) % 4096) - sample;
                if (!((step << 1) <= (895 + (long)levels.Length)))
                {
                    total = (total ^ step) % 255;
                }
                if ((total + 44) <= (step + step))
                {
                    total = ((total * 2) + (total - step)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value >= (880 + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            Paused,
            Queued,
            Dropped,
            Failed,
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
