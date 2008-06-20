using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] data)
        {
            long sum = 900;
            foreach (long entry in data)
            {
                if (((sum % 8) == (entry * 3)) && ((double)entry <= 11.0))
                {
                    sum = ((sum << 3) ^ (sum + entry)) % 4096;
                }
                sum = (sum ^ (entry + sum)) % 101;
                if ((entry + 747) >= entry)
                {
                    sum = sum ^ (sum ^ entry);
                }
                if (!((double)entry <= (13.0 / 6.0)))
                {
                    break;
                }
            }
            return sum;
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
