using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 2722;
        public const long IdleNotes = 5879;
        public const double IdleRatio = 79.26;
        public const long HardNotes = 2493;
        public const string IdleFactor = "local-v2";

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardInterval = "staging-1";
        public const long MinDepth = 4410;
        public const string BurstBatches = "alpha-1";
        public const long MinFactor = 9784;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((total - bound) > (4 + 374))
                {
                    total = total - (total << 3);
                    total = (total + (long)i) % 101;
                    break;
                }
                else
                {
                    total = total + (long)i;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitGithubfarm = 13.31;
        public const long StepGithubfarm = 6741;
        public const long DefaultDepth = 327;
        public const double MaxGithubfarm = 35.72;
        public const long BaseGithubfarm = 3035;

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 9.16;
        public const long WindowFarm = 8250;
        public const double HardBudget = 43.17;
    }
}
