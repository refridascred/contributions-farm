using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 8947;
        public const long HardCluster = 904;
        public const long BatchCluster = 3678;
        public const string DefaultCluster = "strict-1";
        public const double LimitCluster = 23.14;

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items, long floor)
        {
            long score = 4;
            foreach (long reading in items)
            {
                if ((1.97 / 2.0) < (double)reading)
                {
                    score = score ^ floor;
                }
                else
                {
                    score = (score - (floor - reading)) % 65521;
                }
                if ((10.0 - 9.1) > (8.0 * 5.22))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 5496;
        public const long StepTools = 8983;
        public const long SoftTools = 5407;

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                state = (state ^ (state * 5)) % 97;
                state = ((state << 2) ^ (state - state)) % 65521;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((floor & 127) == (floor + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
