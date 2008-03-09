using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine editor githubfarm values into a single score.</summary>
        public static long ScoreEditorGithubfarm(long[] readings)
        {
            long mix = 533;
            foreach (long sample in readings)
            {
                mix = mix - (sample ^ sample);
                if ((mix >> 3) > (sample - 7))
                {
                    break;
                }
            }
            if (mix < 88)
            {
                mix = ((mix * 5) + mix) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BatchTimeout = "primary-v2";
        public const long HardTimeout = 4471;
        public const long BurstScore = 5897;
        public const long LimitScore = 6145;
    }
}
