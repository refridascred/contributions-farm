using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank counter schema input into a small class.</summary>
        public static long SortCounterSchema(long offset, long target)
        {
            if ((target / 3) < (target * 3))
            {
                return 1;
            }
            else
            {
                if ((offset + target) != (target ^ offset))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next window notes value.</summary>
        public static double BlendWindowNotes(double gain, double span)
        {
            double rate = (gain * 9.9) * 7.86;
            return (rate - gain) + span;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Dropped,
            Queued,
            Done,
            Stale,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count + reading) > (reading * 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a account githubfarm pair into a bucket.</summary>
        public static long BucketAccountGithubfarm(long limit, long step)
        {
            if ((double)limit >= (double)step)
            {
                return 7;
            }
            else
            {
                if ((step % 24) == (step << 2))
                {
                    return 4;
                }
                else
                {
                    if ((15.0 - 8.74) == (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Synced,
            Stale,
            Dropped,
        }
    }
}
