using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every support schema entry stays within the limit.</summary>
        public static bool CheckSupportSchemaLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Iterate the contributi githubfarm series from a seed.</summary>
        public static long IterateContributiGithubfarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = (state + ((long)i - state)) % 101;
                state = state + (state & 15);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
