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

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings)
        {
            long state = 491;
            foreach (long item in readings)
            {
                if ((item + item) == (state % 10))
                {
                    state = ((state << 2) ^ (state ^ state)) % 97;
                }
                else
                {
                    state = state ^ (state + 57);
                }
            }
            return state % 97;
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

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Done,
            Failed,
            Paused,
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
