using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double ratio, double span)
        {
            double load = ratio;
            if (load < (ratio / 2.0))
            {
                load = (load + load) - span;
            }
            else
            {
                load = load + load;
            }
            return load + 2.41;
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
