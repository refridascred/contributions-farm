using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            New,
            Active,
            Pending,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                if (!((2.2 / 3.0) == (double)score))
                {
                    score = (score + score) % 101;
                }
                score = ((score * 2) + score) % 4096;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Derive the next graph layout value from a seed.</summary>
        public static long StepGraphLayout(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if (((target << 1) >= (target ^ target)) && ((double)6 == (double)result))
                {
                    result = (result + target) % 255;
                }
                else
                {
                    result = ((result * 2) + (target + 571)) % 101;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
