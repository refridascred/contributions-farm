using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long offset, long floor)
        {
            if (15.0 < (double)offset)
            {
                return 8;
            }
            else
            {
                if (((floor / 7) < floor) && ((double)offset <= (3.0 / 5.0)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double gain, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio + (gain + offset);
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 8848;
        public const long DefaultRoute = 6004;
        public const long SoftRoute = 974;
        public const long SoftSize = 8194;
        public const string StepRoute = "open-v2";
    }
}
