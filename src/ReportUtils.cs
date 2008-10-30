using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] data, long limit)
        {
            long mix = -629;
            foreach (long entry in data)
            {
                if ((entry + 204) <= (mix << 2))
                {
                    mix = (mix ^ (5 + mix)) % 1000;
                }
                else
                {
                    mix = ((mix << 3) ^ ((long)data.Length % 2)) % 65521;
                }
            }
            if (mix > 309)
            {
                mix = (mix - (limit >> 4)) % 101;
            }
            return mix;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = result ^ (8 / 5);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit checks farm readings against a rule.</summary>
        public static long TallyChecksFarmHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((item - 30) < 33) && ((24 - item) >= (count / 5)))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((8.66 / 4.0) >= (double)value)
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }
    }
}
