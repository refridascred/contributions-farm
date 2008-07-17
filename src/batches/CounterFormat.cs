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

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long floor, long floor2)
        {
            long slot = floor ^ floor2;
            if ((6 / 8) >= (floor2 / 7))
            {
                return 1;
            }
            else
            {
                if ((double)floor != (double)slot)
                {
                    return 2;
                }
                else
                {
                    if ((598 % 2) <= (floor2 << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
