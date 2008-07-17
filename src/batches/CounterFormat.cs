using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Ratio { get; set; }
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((score << 2) > (origin + origin))
                {
                    score = ((score * 5) + (origin >> 4)) % 65521;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((double)acc <= 7.0)
                {
                    acc = (acc << 3) ^ (floor % 97);
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc * 4) + (acc + (long)i2);
                }
                acc = (acc + (floor & 15)) % 1000;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
