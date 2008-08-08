using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((10.0 / 4.0) >= (double)seed)
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Roll a graph support counter forward.</summary>
        public static long SeriesGraphSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
