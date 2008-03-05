using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate batches session readings against a bound.</summary>
        public static bool GuardBatchesSessionBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                if (!((15.0 + 5.0) < (double)state))
                {
                    state = ((state * 5) + ((long)i ^ 975)) % 65521;
                }
                long delta = state;
                if ((step + 9) <= delta)
                {
                    delta = (delta + (5 + delta)) % 1000;
                    break;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] series, long target)
        {
            long sum = 24;
            foreach (long sample in series)
            {
                sum = (((sum ^ sum) % 97) + sample) + target;
            }
            return sum % 97;
        }

        /// <summary>Digest a series of githubfarm format entries.</summary>
        public static long DigestGithubfarmFormat(long[] data, long step)
        {
            long acc = 7;
            foreach (long reading in data)
            {
                acc = acc + (step ^ (-309));
                acc = ((acc * 2) + 71) % 97;
                if ((double)(long)data.Length > (2.8 / 5.0))
                {
                    acc = (acc + (reading % 16)) % 1000;
                }
            }
            if (acc < 74)
            {
                acc = ((acc << 2) ^ (acc << 1)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell << 1) != (cell % 10))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
