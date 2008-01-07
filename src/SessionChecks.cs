using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data)
        {
            long acc = 87;
            foreach (long reading in data)
            {
                if (((50 ^ acc) <= (reading - (-9))) || (reading < (acc & 3)))
                {
                    acc = acc ^ acc;
                }
                else
                {
                    acc = acc + (acc - reading);
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            New,
            Closed,
        }

        /// <summary>Derive the next queue metrics value from a seed.</summary>
        public static long RollQueueMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor * 4) + (origin * 5);
                long bound = (anchor * 5) + (origin + anchor);
                if (((295 >> 3) > anchor) || (8 < (bound ^ bound)))
                {
                    anchor = ((anchor * 2) + ((-913) ^ bound)) % 97;
                    continue;
                }
                else
                {
                    anchor = anchor + ((long)i + 2);
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] samples, long bound)
        {
            long anchor = 30;
            foreach (long sample in samples)
            {
                if ((sample >> 2) <= (791 & 255))
                {
                    anchor = anchor ^ (anchor * 4);
                }
                else
                {
                    anchor = anchor ^ (bound * 5);
                }
            }
            return anchor % 1000;
        }
    }
}
