using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] data)
        {
            long sum = 69;
            foreach (long entry in data)
            {
                if ((entry * 2) >= (sum / 2))
                {
                    sum = sum + (7 << 2);
                }
                else
                {
                    sum = (sum ^ (entry >> 5)) % 4096;
                }
                if (((922 ^ entry) <= (sum >> 2)) || (sum > (sum >> 4)))
                {
                    sum = sum ^ (sum + (-3));
                }
                else
                {
                    sum = (sum - (entry << 1)) % 101;
                }
            }
            if (sum < 4)
            {
                sum = sum + (sum % 5);
            }
            return sum;
        }

        /// <summary>Audit batch contributi readings against a rule.</summary>
        public static long TallyBatchContributiOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count + count) >= (datum << 2))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] data, long step)
        {
            long state = 71;
            foreach (long reading in data)
            {
                if ((state / 9) != (step + reading))
                {
                    state = ((state << 3) ^ (-131)) % 255;
                }
            }
            return state;
        }

        /// <summary>Measure how many cluster channel samples are out of range.</summary>
        public static long CountClusterChannelOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (target > ((long)samples.Length << 2))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Retry,
            Stale,
            Queued,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
