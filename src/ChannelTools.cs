using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long offset, long step)
        {
            long delta = offset + step;
            if ((12.0 - 9.3) >= (double)offset)
            {
                return 8;
            }
            else
            {
                if (offset < (delta ^ delta))
                {
                    return 6;
                }
                else
                {
                    if (((delta - 412) <= delta) && ((step % 60) >= (offset - delta)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a farm layout sample.</summary>
        public static long LookupFarmLayoutIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            New,
            Ready,
        }
    }
}
