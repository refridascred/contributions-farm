using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + mix) % 101;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a command queue counter forward.</summary>
        public static long DeriveCommandQueue(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                state = (state + (bound >> 5)) % 97;
                state = (state + (state + bound)) % 255;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 9938;
        public const double HardScore = 7.71;
        public const long MinToken = 6926;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (step + total)) % 1000;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = (total ^ ((long)i & 3)) ^ (long)i2;
                    total = ((total << 2) ^ (total / 7)) % 4096;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Count { get; set; } = "";
            public double Level { get; set; }
            public long Token { get; set; }
        }
    }
}
