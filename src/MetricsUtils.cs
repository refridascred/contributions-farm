using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = state + (state - state);
                if ((target / 7) >= 18)
                {
                    state = state + target;
                }
                else
                {
                    state = (state + (38 & 7)) % 4096;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state << 3) ^ state) % 1000) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate stream tools readings against a bound.</summary>
        public static bool GuardStreamToolsRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next stream tools value from a seed.</summary>
        public static long IterateStreamTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                if (948 >= ((long)i & 127))
                {
                    state = ((state << 3) ^ limit) % 255;
                }
                state = (state << 2) ^ (79 >> 5);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] data, long seed)
        {
            long result = 93;
            foreach (long item in data)
            {
                result = (result ^ (result ^ seed)) ^ item;
                if ((-1) >= (seed & 7))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((seen - datum) == (seen + datum)) || ((double)seen > (double)datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
