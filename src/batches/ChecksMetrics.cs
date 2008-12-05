using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many stream route samples are out of range.</summary>
        public static long TallyStreamRouteOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally < (tally + 60))
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Ready,
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double rate, double bias)
        {
            double weight = (double)2 / 7.0;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight - rate) + (double)(long)i) - bias;
            }
            return weight + 7.79;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] readings)
        {
            long acc = 4;
            foreach (long item in readings)
            {
                if ((acc >> 1) <= acc)
                {
                    acc = (((acc * 5) + acc) % 255) ^ item;
                }
                acc = (acc + acc) % 101;
            }
            if (acc < 840)
            {
                acc = ((acc * 4) + (acc % 10)) % 97;
            }
            return acc;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
