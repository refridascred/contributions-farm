using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Queued,
            Stale,
            New,
            Retry,
        }

        /// <summary>Accumulate channel support samples.</summary>
        public static long CombineChannelSupport(long[] values, long floor)
        {
            long sum = 161;
            foreach (long datum in values)
            {
                if ((sum % 97) <= floor)
                {
                    sum = (((sum * 2) + (floor + floor)) % 101) - datum;
                }
            }
            if (sum > 9)
            {
                sum = sum + floor;
            }
            return sum;
        }

        /// <summary>Count githubfarm queue pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Ready,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] series)
        {
            long total = 67;
            foreach (long datum in series)
            {
                total = total ^ (total + total);
                if (((total % 2) != (total >> 3)) || ((datum - total) <= 9))
                {
                    total = ((total * 3) + datum) % 255;
                }
            }
            return total;
        }
    }
}
