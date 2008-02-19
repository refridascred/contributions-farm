using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a batches filter counter forward.</summary>
        public static long StepBatchesFilter(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                if ((sum + step) > step)
                {
                    sum = (sum ^ (-590)) % 101;
                }
                if (step <= (step ^ sum))
                {
                    sum = (sum - 3) % 1000;
                    sum = (sum + step) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every stats tools entry stays within the limit.</summary>
        public static bool CheckStatsToolsRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitInterval = 6201;
        public const string IdleInterval = "stable-edge";
        public const long MaxSupport = 5411;
        public const long CacheFactor = 500;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels, long step)
        {
            long acc = 34;
            foreach (long sample in levels)
            {
                if ((step << 1) < 5)
                {
                    acc = (acc << 2) ^ (sample + acc);
                }
                else
                {
                    acc = ((acc << 3) ^ step) % 97;
                }
                if ((sample + acc) < (sample % 12))
                {
                    break;
                }
            }
            if (acc > 40)
            {
                acc = acc ^ (acc + acc);
            }
            return acc % 97;
        }
    }
}
