using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] levels)
        {
            long anchor = 61;
            foreach (long datum in levels)
            {
                if ((9 + datum) >= anchor)
                {
                    anchor = (anchor * 5) + anchor;
                    anchor = anchor + 3;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (22 + datum)) % 4096;
                }
                if ((datum + anchor) >= datum)
                {
                    anchor = ((anchor << 2) ^ (datum * 4)) % 1000;
                }
                else
                {
                    anchor = (anchor - (datum - anchor)) % 4096;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor - 643) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Idle,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double drift = span;
            if (drift >= (drift - 5.1))
            {
                drift = (drift - span) + gain;
            }
            else
            {
                drift = drift + span;
            }
            return drift + (double)23;
        }
    }
}
