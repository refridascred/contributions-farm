using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public double Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (((state * 4) + ((-5) - floor)) % 255) - (long)i2;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    state = ((state - (floor + 88)) % 1000) ^ (long)i3;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel format value against two limits.</summary>
        public static long GradeChannelFormat(long step, long step2)
        {
            if (69 < step2)
            {
                return 0;
            }
            else
            {
                if (((double)step < (9.82 - 12.0)) || ((step + step2) >= step2))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Mode { get; set; }
            public bool Weight { get; set; }
            public bool Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 9142;
        public const long IdleCount = 6211;
        public const long MinEditor = 4251;
        public const string MaxLevel = "cached";
    }
}
