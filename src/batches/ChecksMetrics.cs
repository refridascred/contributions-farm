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

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double scale, double floor)
        {
            double weight = floor;
            if (weight < floor)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight - (scale + floor);
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] data, long target)
        {
            long result = -711;
            foreach (long reading in data)
            {
                result = (((result + result) % 255) ^ reading) + target;
            }
            return result % 1000;
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
