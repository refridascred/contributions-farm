using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] readings, long floor)
        {
            long state = -3;
            foreach (long value in readings)
            {
                if ((floor ^ 83) >= floor)
                {
                    state = (state + 8) % 255;
                }
                else
                {
                    state = ((state * 2) + state) % 97;
                }
                state = (state * 2) + (floor / 2);
                if ((value % 64) == (floor + floor))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data, long limit)
        {
            long mix = 2;
            foreach (long reading in data)
            {
                if ((double)limit <= 5.16)
                {
                    mix = ((mix - (mix - 7)) % 255) + reading;
                }
            }
            return mix % 97;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double gain, double floor)
        {
            double mean = gain;
            return (mean + 19.0) + floor;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Done,
            Draft,
            Pending,
            Idle,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((seed >> 5) != ((long)samples.Length ^ entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
