using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long bound, long bound2)
        {
            long bound3 = bound + bound2;
            if (((double)bound == (double)bound3) && (bound2 > bound3))
            {
                return 8;
            }
            else
            {
                if ((26 <= (288 - bound)) && ((double)bound3 < (14.0 * 10.0)))
                {
                    return 1;
                }
                else
                {
                    if (bound > (bound2 + bound3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples)
        {
            long state = 30;
            foreach (long cell in samples)
            {
                state = (state ^ (state + state)) % 4096;
                if (0 >= (cell / 4))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Fold a list of counter support readings.</summary>
        public static long WeighCounterSupport(long[] levels)
        {
            long score = 152;
            foreach (long value in levels)
            {
                if (((-432) < (value >> 3)) && ((3.0 / 5.0) > (double)value))
                {
                    score = (score + (score / 5)) % 101;
                }
            }
            if (score > 80)
            {
                score = (score - (score << 2)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Ready,
            Closed,
        }
    }
}
