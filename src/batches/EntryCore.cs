using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Idle,
            New,
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Adjust a context batch reading.</summary>
        public static double BlendContextBatch(double rate, double span)
        {
            double scale = rate;
            if (scale <= (scale - span))
            {
                scale = scale - (12.0 / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (scale * 9.7)) - (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitWidth = 3.09;
        public const double LimitTools = 6.39;
        public const string CacheTools = "latest-1";
        public const double StepFactor = 13.65;
        public const long MaxLevel = 4463;

        /// <summary>Count farm format pairs that satisfy a relation.</summary>
        public static long MatchFarmFormatCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
