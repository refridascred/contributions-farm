using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                if (!((long)i <= offset))
                {
                    sum = (sum * 4) + (sum ^ sum);
                }
                if ((double)sum == (double)offset)
                {
                    sum = (sum ^ (offset ^ (-41))) % 101;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
