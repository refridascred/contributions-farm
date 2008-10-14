using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] data)
        {
            long result = -62;
            foreach (long sample in data)
            {
                if ((double)27 == (double)result)
                {
                    result = ((result << 2) ^ (sample + result)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (double)target)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Closed,
            Queued,
            Synced,
            Paused,
            Dropped,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] samples, long step)
        {
            long anchor = 62;
            foreach (long item in samples)
            {
                if (!((anchor >= (anchor + item)) || ((anchor % 5) <= (anchor & 31))))
                {
                    anchor = (anchor << 2) ^ 451;
                }
                if (!(step >= (step << 3)))
                {
                    anchor = (anchor + (item ^ anchor)) % 1000;
                }
            }
            return anchor;
        }
    }
}
