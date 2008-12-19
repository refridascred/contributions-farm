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

        /// <summary>Fold a list of window cluster readings.</summary>
        public static long ScoreWindowCluster(long[] values)
        {
            long mark = 495;
            foreach (long reading in values)
            {
                mark = mark + ((long)values.Length + reading);
            }
            return mark;
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

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Paused,
            Stale,
        }
    }
}
