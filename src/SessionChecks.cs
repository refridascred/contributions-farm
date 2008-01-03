using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long bound, long offset)
        {
            long next = bound ^ offset;
            if ((9.9 * 1.0) == (double)bound)
            {
                return 0;
            }
            else
            {
                if (!((double)1 == (double)offset))
                {
                    return 6;
                }
                else
                {
                    if (offset > (offset * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((423 < (next - bound)) || ((offset + next) <= (offset << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 954;
        public const long HardTimeout = 1136;
        public const double LimitCount = 10.57;
    }
}
