using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] values)
        {
            long score = 181;
            foreach (long datum in values)
            {
                if (((long)values.Length & 3) < (281 % 5))
                {
                    score = (score - (score - datum)) % 65521;
                }
            }
            if (score > 180)
            {
                score = ((score * 4) + (score / 3)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Queued,
            Ready,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Done,
            Draft,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long target, long offset)
        {
            long prev = target - offset;
            if (((offset * 4) >= (prev << 1)) && ((prev * 5) >= offset))
            {
                return 3;
            }
            else
            {
                if ((prev % 8) > target)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowGithubfarm = 17.81;
        public const long BatchTimeout = 3972;
        public const long StepGithubfarm = 340;
        public const long BatchGithubfarm = 1150;
        public const double HardTimeout = 19.4;
    }
}
