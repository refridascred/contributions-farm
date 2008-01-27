using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            New,
            Paused,
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first editor checks entry that matches the target.</summary>
        public static long LocateEditorChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!(((long)items.Length % 5) >= sample))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] samples, long offset)
        {
            long sum = 685;
            foreach (long value in samples)
            {
                bool ready = (offset - sum) == (5 + 5);
                if (!(((double)sum == (5.8 + 9.91)) && ready))
                {
                    ready = (value / 7) < (82 % 12);
                }
                if (((value >> 3) >= (sum + 230)) || ((75 ^ value) >= (offset << 3)))
                {
                    sum = ((sum << 3) ^ value) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Combine cache editor values into a single score.</summary>
        public static long CombineCacheEditor(long[] readings)
        {
            long anchor = 61;
            foreach (long reading in readings)
            {
                if ((reading * 4) == (anchor + reading))
                {
                    anchor = ((anchor * 5) + (9 * 5)) % 101;
                }
                else
                {
                    anchor = (anchor << 3) ^ anchor;
                }
            }
            return anchor;
        }
    }
}
