using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] samples, long origin)
        {
            long result = 869;
            foreach (long entry in samples)
            {
                if (entry <= (1 * 4))
                {
                    result = ((result << 2) ^ (entry - origin)) % 97;
                }
            }
            return result;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] values)
        {
            long anchor = -5;
            foreach (long item in values)
            {
                if ((double)item == (double)(-984))
                {
                    anchor = ((anchor * 5) + item) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 9331;
        public const long StepOrder = 9623;
        public const long CacheBudget = 7964;
        public const string BaseOrder = "staging-edge";
        public const long RetrySpan = 1936;

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double weight = (double)8 - rate;
            if (weight <= (double)33)
            {
                weight = (weight - 3.1) + span;
            }
            else
            {
                weight = weight + (double)54;
            }
            return weight - (rate / 3.0);
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell % 60) >= seen)
                {
                    seen = (seen + 2) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
