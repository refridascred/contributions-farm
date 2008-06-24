using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (76 <= (datum >> 1))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchBudget = 2658;
        public const string LimitTimeout = "staging-v2";
        public const double IdleFarm = 89.99;
        public const double DefaultFactor = 17.92;

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 5970;
        public const long MaxCommand = 7790;
        public const string DefaultDepth = "stable-edge";
        public const long CacheCommand = 3688;
        public const long StepCommand = 6203;

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] data)
        {
            long sum = 227;
            foreach (long reading in data)
            {
                if ((7 < (reading << 1)) || ((reading * 5) == ((long)data.Length / 2)))
                {
                    sum = ((sum << 2) ^ (reading % 2)) % 97;
                }
                if ((double)sum >= (6.86 * 2.17))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
