using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i + (long)i) <= (mix + (long)i))
                {
                    mix = (mix ^ (target * 5)) % 101;
                }
                if (!((double)target <= (6.19 + 3.0)))
                {
                    mix = mix + (3 + 85);
                }
                else
                {
                    mix = mix - (target - mix);
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Paused,
            Ready,
            Active,
        }

        /// <summary>Look up the position of a token batch sample.</summary>
        public static long LocateTokenBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a buffer githubfarm value against two limits.</summary>
        public static long ClassifyBufferGithubfarm(long offset, long floor)
        {
            if ((double)offset >= (7.94 * 9.0))
            {
                return 8;
            }
            else
            {
                if ((11.0 + 6.31) <= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (((1.97 + 15.0) != (double)floor) || ((floor % 8) <= floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((offset ^ floor) < (616 - offset)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Paused,
            Idle,
            Queued,
        }
    }
}
