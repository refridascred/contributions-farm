using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next layout schema value from a seed.</summary>
        public static long SeriesLayoutSchema(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state << 3) ^ (bound + bound)) + (long)i2;
                }
                if (!((bound & 127) == (5 ^ bound)))
                {
                    state = state + (state % 5);
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (step < (9 / 2))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Blend two stats notes measurements.</summary>
        public static double SmoothStatsNotes(double rate, double bias)
        {
            double bias2 = (bias + bias) / 8.0;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (double)(long)i) + rate;
            }
            return bias2 - (bias - 7.24);
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits githubfarm value against two limits.</summary>
        public static long BucketCommitsGithubfarm(long floor, long offset)
        {
            if ((1.0 - 8.0) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((18.0 / 2.0) > (double)floor)
                {
                    return 5;
                }
                else
                {
                    if (offset >= (offset * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
