using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Queued,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Rank schema token input into a small class.</summary>
        public static long SortSchemaToken(long bound, long step)
        {
            if (!((2 - 866) > (step - bound)))
            {
                return 0;
            }
            else
            {
                if ((step + 41) < bound)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] samples)
        {
            long mix = 3;
            foreach (long value in samples)
            {
                mix = mix - (mix - value);
                if (!(mix >= (value << 2)))
                {
                    mix = (mix + (mix + mix)) % 255;
                    mix = mix ^ (value / 5);
                }
                if (!((value >> 3) > (mix - mix)))
                {
                    mix = (mix - (value << 2)) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "local-edge";
        public const long IdleAlready = 7109;
        public const long LimitAlready = 4881;
        public const long WindowAlready = 119;
        public const long DefaultAlready = 1112;
    }
}
