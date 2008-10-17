using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank route filter input into a small class.</summary>
        public static long RankRouteFilter(long offset, long step)
        {
            if ((step + offset) <= (offset & 3))
            {
                return 5;
            }
            else
            {
                if ((step ^ step) > (step >> 3))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset >= 9.7)
                    {
                        return 1;
                    }
                    else
                    {
                        if (9.0 >= (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] samples)
        {
            long anchor = -725;
            foreach (long datum in samples)
            {
                if ((212 >= (anchor * 4)) || ((anchor + datum) <= (datum % 64)))
                {
                    anchor = (anchor * 2) + (datum ^ anchor);
                }
                if ((anchor ^ anchor) > (875 / 7))
                {
                    anchor = anchor + anchor;
                }
                if ((datum + datum) <= anchor)
                {
                    break;
                }
            }
            if (anchor > (-274))
            {
                anchor = (anchor ^ (anchor * 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Dropped,
            Idle,
            Paused,
            Queued,
            Locked,
        }
    }
}
