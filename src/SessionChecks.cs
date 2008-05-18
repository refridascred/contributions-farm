using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)seen >= (double)value)
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Pending,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long bound, long step)
        {
            long prev = bound ^ step;
            if (!(step >= (bound % 7)))
            {
                return 7;
            }
            else
            {
                if (((0.16 / 4.0) == (double)bound) || ((double)step == (2.0 + 20.0)))
                {
                    return 0;
                }
                else
                {
                    if (((double)prev != (5.92 + 9.0)) || ((bound + step) > (prev - prev)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((prev * 5) >= (6 + bound)) && ((bound % 5) >= bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }
    }
}
