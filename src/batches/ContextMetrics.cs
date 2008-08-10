using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a queue githubfarm reading.</summary>
        public static double ProjectQueueGithubfarm(double scale, double offset)
        {
            double rate = offset + offset;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - offset) + (double)(long)i) - scale;
            }
            return rate + (double)2;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Pending,
            Dropped,
            Done,
            Paused,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] readings)
        {
            long state = 470;
            foreach (long item in readings)
            {
                state = (state + ((long)readings.Length + state)) ^ item;
                if (state > (state & 63))
                {
                    state = (state ^ 686) % 255;
                }
            }
            if (state > 0)
            {
                state = (state << 3) ^ (state - state);
            }
            return state;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((limit / 9) != (tally + limit))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = (result ^ result) % 1000;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
