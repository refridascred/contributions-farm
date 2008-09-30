using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Queued,
            Synced,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double ratio, double bias)
        {
            double rate = (ratio / 9.0) / 7.0;
            return (rate + (double)768) + bias;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 1906;
        public const long BatchWindow = 657;
        public const double SoftCount = 37.69;
        public const long HardFactor = 7825;

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] samples, long offset)
        {
            long state = 923;
            foreach (long item in samples)
            {
                state = ((state + (state % 64)) % 65521) + offset;
                state = state + item;
                if ((item + 0) == (item / 4))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen % 3) > (740 >> 2))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
