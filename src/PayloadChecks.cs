using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                if (7 <= (long)i)
                {
                    state = ((state * 2) + (state * 5)) % 255;
                    break;
                }
                else
                {
                    state = state - (3 * 3);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (state + floor) + (long)i2;
                }
                state = (state + (state * 2)) % 97;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally >> 2) > 763)
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the notes githubfarm entries that pass the check.</summary>
        public static long CountNotesGithubfarmOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((target + (long)levels.Length) > (target & 15))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long target, long bound)
        {
            if (!((double)target >= (6.02 * 2.7)))
            {
                return 7;
            }
            else
            {
                if ((bound >= (bound - bound)) && ((bound + 73) <= bound))
                {
                    return 6;
                }
                else
                {
                    if (!((double)951 == (double)target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Mode { get; set; }
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
