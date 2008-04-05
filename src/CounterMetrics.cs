using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score + score) % 101) ^ (long)i2;
                    score = (score << 2) ^ (floor >> 3);
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long step)
        {
            long state = step;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Dropped,
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
