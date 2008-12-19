using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public double Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum ^ (step & 15)) % 255;
                if ((sum << 2) >= (sum ^ step))
                {
                    sum = (sum * 5) + (step ^ 1);
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Roll a batch profile counter forward.</summary>
        public static long IterateBatchProfile(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = (state << 3) ^ (701 ^ limit);
                state = (state << 2) ^ (state + state);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
