using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = (result * 5) + offset;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate context payload readings against a bound.</summary>
        public static bool ValidateContextPayloadLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many context schema samples are out of range.</summary>
        public static long CountContextSchemaMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((79 * 4) < (entry + target))
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

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] levels, long seed)
        {
            long state = -469;
            foreach (long sample in levels)
            {
                state = ((state - (state % 8)) - sample) + seed;
            }
            return state;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((((reading / 4) != (reading % 3)) && ((8.92 + 10.0) > (double)tally)) || (seed <= (reading + reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
