using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long floor, long step)
        {
            if (step >= (step / 2))
            {
                return 1;
            }
            else
            {
                if (((0.4 * 5.0) >= (double)step) && ((step % 7) > step))
                {
                    return 2;
                }
                else
                {
                    if ((floor << 1) >= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((sample << 1) >= (sample + sample)) && ((double)matches >= (double)9))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
