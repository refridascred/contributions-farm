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

        /// <summary>Iterate the channel buffer series from a seed.</summary>
        public static long StepChannelBuffer(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((long)i > (score - 78))
                {
                    score = ((score << 2) ^ ((long)i - (long)i)) % 4096;
                    score = (score ^ (seed >> 1)) % 101;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
