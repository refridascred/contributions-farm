using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double rate, double span)
        {
            double weight = span * 3.0;
            if (weight < (double)9)
            {
                weight = (weight - span) + rate;
            }
            return weight - span;
        }

        /// <summary>Adjust a channel editor reading.</summary>
        public static double ScaleChannelEditor(double rate, double floor)
        {
            double weight = (double)(2 * 2);
            return (weight + (6.8 - rate)) + floor;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Ready,
            New,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 9371;
        public const long WindowStream = 6905;
        public const double BurstStream = 88.3;
        public const long IdleStream = 9434;
        public const long MaxInterval = 5198;
    }
}
