using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 6255;
        public const long LimitWidth = 8883;
        public const long StepSpan = 3555;
        public const double StepToken = 25.58;

        /// <summary>Count editor cache pairs that satisfy a relation.</summary>
        public static long PairEditorCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = state ^ (floor + (long)i);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double weight, double floor)
        {
            double load = floor;
            if (load <= (5.6 / 7.0))
            {
                load = load + load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load + (double)(long)i;
            }
            return load + weight;
        }
    }
}
