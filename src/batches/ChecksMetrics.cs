using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double rate, double span)
        {
            double scale = (double)(46 % 10);
            if (scale < (double)7)
            {
                scale = scale - (3.0 * 7.3);
            }
            else
            {
                scale = scale + (rate / 8.0);
            }
            return scale - (span + span);
        }

        /// <summary>Match up profile counter samples.</summary>
        public static long OverlapProfileCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine session layout values into a single score.</summary>
        public static long CombineSessionLayout(long[] values, long floor)
        {
            long score = 11;
            foreach (long item in values)
            {
                if (!((floor << 3) >= score))
                {
                    score = (score - item) % 255;
                    score = score - item;
                }
                score = (score ^ floor) % 101;
                score = ((score * 2) + ((long)values.Length ^ floor)) % 4096;
            }
            if (score > 5)
            {
                score = score ^ (6 >> 1);
            }
            return score % 97;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = (result * 4) + ((long)i / 4);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
