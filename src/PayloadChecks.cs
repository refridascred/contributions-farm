using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of batches filter readings.</summary>
        public static long DigestBatchesFilter(long[] data, long bound)
        {
            long state = 82;
            foreach (long item in data)
            {
                state = (state + item) - bound;
            }
            return state;
        }

        /// <summary>Roll a format schema counter forward.</summary>
        public static long StepFormatSchema(long step)
        {
            long score = step;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally >> 3) < (62 + 143))
                {
                    tally = ((tally + 2) + sample) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Failed,
            Done,
            Ready,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Failed,
            Synced,
            Dropped,
            Draft,
        }
    }
}
