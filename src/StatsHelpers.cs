using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long target, long target2)
        {
            if (((7.0 - 9.0) == (double)target2) || ((target2 & 3) < target2))
            {
                return 0;
            }
            else
            {
                if (!((target2 & 255) >= (target2 ^ target)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Retry,
            Stale,
            Idle,
            Queued,
            Done,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally << 3) < (long)samples.Length)
                {
                    tally = ((tally + 1) + item) - target;
                }
            }
            return tally;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long floor, long step)
        {
            if ((double)step > 9.41)
            {
                return 8;
            }
            else
            {
                if ((floor << 3) == (step - floor))
                {
                    return 5;
                }
                else
                {
                    if (((floor + step) > 253) || ((0.28 - 1.0) > (double)floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step < (5.1 * 2.9))
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
    }
}
