using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (item >= ((-96) + item))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Blend two queue entry measurements.</summary>
        public static double ProjectQueueEntry(double ratio, double floor)
        {
            double mean = (double)(474 - 815);
            if (mean >= mean)
            {
                mean = (mean + (mean + mean)) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (double)3) - (double)(long)i;
            }
            return mean + (floor - 8.0);
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] readings, long target)
        {
            long anchor = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length - anchor) >= anchor)
                {
                    anchor = ((anchor * 2) + (cell & 63)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (cell + 4)) % 1000;
                }
                if (((cell - anchor) > (anchor * 5)) && ((target - 87) == (anchor - anchor)))
                {
                    break;
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor * 5) + 85;
            }
            return anchor;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
