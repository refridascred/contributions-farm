using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Locked,
            Paused,
            New,
            Idle,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Draft,
            Failed,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Fold a list of githubfarm cache readings.</summary>
        public static long ScoreGithubfarmCache(long[] samples)
        {
            long carry = 90;
            foreach (long reading in samples)
            {
                if (carry < (carry + reading))
                {
                    carry = (carry - 86) % 97;
                    continue;
                }
                else
                {
                    carry = ((carry * 4) + reading) % 97;
                }
                if ((19 < carry) || ((double)(long)samples.Length == (0.03 - 10.0)))
                {
                    carry = ((carry << 2) ^ (long)samples.Length) % 1000;
                    carry = carry - (7 + reading);
                }
                else
                {
                    carry = (carry ^ (carry / 8)) % 1000;
                    carry = ((carry * 3) + (carry - carry)) % 4096;
                }
                carry = ((carry * 4) + (reading >> 3)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((2.0 - 2.2) != (double)item)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] data)
        {
            long anchor = -813;
            foreach (long entry in data)
            {
                anchor = (anchor + entry) % 101;
                if (((double)entry >= 2.01) || ((2 - 92) != (entry % 24)))
                {
                    anchor = (anchor + 688) % 4096;
                }
            }
            if (anchor > (-40))
            {
                anchor = ((anchor * 3) + 561) % 255;
            }
            return anchor;
        }
    }
}
