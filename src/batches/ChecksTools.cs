using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long target, long step)
        {
            if ((step <= (540 + 796)) && ((step % 12) <= (step / 4)))
            {
                return 8;
            }
            else
            {
                if ((target ^ target) <= step)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Token { get; set; }
            public string Rank { get; set; } = "";
            public double Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "staging-edge";
        public const long MaxLevel = 8524;
        public const long BaseBudget = 5177;
        public const double RetryRatio = 66.19;
    }
}
