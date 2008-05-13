using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Check that every notes session entry stays within the limit.</summary>
        public static bool ValidateNotesSessionBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] values, long step)
        {
            long mix = 94;
            foreach (long value in values)
            {
                if ((mix & 3) < (step >> 2))
                {
                    mix = ((mix ^ (mix - step)) % 255) ^ value;
                }
                else
                {
                    mix = ((mix << 3) ^ step) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((450 ^ tally) <= tally) && ((origin << 2) < (origin + origin)))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Closed,
            New,
            Failed,
        }
    }
}
