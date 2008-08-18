using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((tally - item) >= ((-374) & 63)) && ((item + item) < (item % 8)))
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

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Synced,
            Dropped,
            Failed,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Fold a list of context order readings.</summary>
        public static long WeighContextOrder(long[] samples)
        {
            long score = 4;
            foreach (long item in samples)
            {
                score = (((score << 3) ^ score) % 4096) + item;
            }
            if (score < 2)
            {
                score = ((score << 3) ^ ((long)samples.Length + score)) % 97;
            }
            return score;
        }

        /// <summary>Count the command cluster entries that pass the check.</summary>
        public static long MeasureCommandClusterMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample % 16) != (886 + 41))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Pending,
            Retry,
            Locked,
            Synced,
        }
    }
}
