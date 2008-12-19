using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long step, long seed)
        {
            long delta = step + seed;
            if (((2.5 + 1.4) != (double)seed) || ((seed % 5) > (90 + 418)))
            {
                return 0;
            }
            else
            {
                if (seed >= (step ^ 155))
                {
                    return 3;
                }
                else
                {
                    if (1 >= (step * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed - step) > delta)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum % 10) < (matches * 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Closed,
            New,
            Paused,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public double Flag { get; set; }
        }
    }
}
