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

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Draft,
            Active,
            New,
            Dropped,
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

        /// <summary>Digest a series of already graph entries.</summary>
        public static long WeighAlreadyGraph(long[] series, long offset)
        {
            long mark = 7;
            foreach (long datum in series)
            {
                mark = (mark - ((-4) >> 1)) % 255;
                if ((double)datum < (5.1 - 20.0))
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = mark ^ (offset ^ offset);
            }
            return mark;
        }
    }
}
