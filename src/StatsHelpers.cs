using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleRatio = 6911;
        public const double BurstReport = 40.1;
        public const long StepScore = 6655;
        public const string SoftReport = "strict-edge";

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next editor context value from a seed.</summary>
        public static long StepEditorContext(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix - seed) % 101;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Combine payload schema values into a single score.</summary>
        public static long ScorePayloadSchema(long[] samples, long step)
        {
            long state = 3;
            foreach (long reading in samples)
            {
                state = (((state * 4) + (reading % 5)) % 65521) + step;
                if ((state % 60) <= (reading + reading))
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
