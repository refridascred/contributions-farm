using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long seed, long step)
        {
            long slot = seed - step;
            if ((step + seed) >= slot)
            {
                return 8;
            }
            else
            {
                if (slot > (seed >> 1))
                {
                    return 2;
                }
                else
                {
                    if ((step ^ 426) < step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step ^ slot) <= (step - step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                mark = mark ^ mark;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] samples, long step)
        {
            long anchor = 2;
            foreach (long value in samples)
            {
                anchor = ((anchor ^ (step << 1)) % 97) ^ value;
                anchor = anchor - (anchor - anchor);
            }
            if (anchor > 39)
            {
                anchor = (anchor << 3) ^ (anchor * 4);
            }
            return anchor;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
