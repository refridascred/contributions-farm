using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = (score * 3) + (step + score);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Classify a token profile pair into a bucket.</summary>
        public static long GradeTokenProfile(long seed, long offset)
        {
            long next = seed - offset;
            if (next <= (offset & 3))
            {
                return 6;
            }
            else
            {
                if ((seed - next) > (offset & 31))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
