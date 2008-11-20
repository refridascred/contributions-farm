using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] data)
        {
            long anchor = 50;
            foreach (long reading in data)
            {
                if ((872 - 7) > reading)
                {
                    anchor = (anchor ^ (reading % 8)) % 65521;
                }
                else
                {
                    anchor = (anchor * 3) + ((long)data.Length / 8);
                }
                if ((anchor ^ anchor) >= reading)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long state = step;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Blend two queue cache measurements.</summary>
        public static double ProjectQueueCache(double ratio, double bias)
        {
            double load = bias + (bias / 6.0);
            if (load <= (load - load))
            {
                load = (load - (double)21) + ratio;
            }
            return load + (load - 18.0);
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Retry,
            Idle,
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double scale, double bias)
        {
            double ratio = scale;
            if (ratio > (double)61)
            {
                ratio = (ratio + (double)365) + bias;
            }
            return ratio - (5.3 - scale);
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
