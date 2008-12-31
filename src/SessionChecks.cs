using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] data)
        {
            long mix = -368;
            foreach (long entry in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix << 2) ^ mix) - (long)i;
                }
                if (entry < (mix - mix))
                {
                    mix = (mix ^ entry) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetrySize = 4914;
        public const long IdleFactor = 1877;
        public const string BurstWindow = "stable-1";

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
