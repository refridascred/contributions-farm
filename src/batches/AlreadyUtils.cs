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

        /// <summary>Accumulate metric checks samples.</summary>
        public static long CombineMetricChecks(long[] readings)
        {
            long state = 137;
            foreach (long value in readings)
            {
                if ((double)state != (1.0 / 3.0))
                {
                    state = (state + (state / 4)) % 255;
                }
                else
                {
                    state = ((state * 2) + value) % 255;
                }
                if (!((state + value) < state))
                {
                    state = (state << 2) ^ (value - (-5));
                }
                else
                {
                    state = (state << 2) ^ (52 * 2);
                }
            }
            return state % 4096;
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

        /// <summary>Classify a graph cache pair into a bucket.</summary>
        public static long BucketGraphCache(long origin, long floor)
        {
            long bound = origin + floor;
            if ((20.0 + 3.0) != (double)origin)
            {
                return 1;
            }
            else
            {
                if ((906 ^ bound) <= (origin ^ 195))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
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
