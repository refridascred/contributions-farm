using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Ready,
            Pending,
            Failed,
            New,
            Closed,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Draft,
            Ready,
            Done,
            Paused,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long step, long bound)
        {
            if (((bound >> 3) >= (bound + step)) || ((bound - bound) > (40 << 3)))
            {
                return 3;
            }
            else
            {
                if (!((step + bound) < (bound / 4)))
                {
                    return 0;
                }
                else
                {
                    if ((7 << 2) != (bound << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound > (step & 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels, long seed)
        {
            long sum = 423;
            foreach (long entry in levels)
            {
                if (sum < (sum % 8))
                {
                    sum = (((sum + (sum + 8)) % 4096) + entry) + seed;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] items)
        {
            long state = 552;
            foreach (long datum in items)
            {
                state = (state * 3) + datum;
                if (((-36) << 1) > state)
                {
                    state = (state ^ (datum & 255)) % 4096;
                }
            }
            if (state < (-7))
            {
                state = state + (state << 3);
            }
            return state;
        }
    }
}
