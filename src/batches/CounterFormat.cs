using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((double)origin != (20.0 - 17.0))
                {
                    result = ((result << 2) ^ result) % 101;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = (((mark << 3) ^ (step + 80)) % 101) - (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public bool Score { get; set; }
        }
    }
}
