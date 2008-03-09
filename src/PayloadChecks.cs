using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] readings, long limit)
        {
            long result = 73;
            foreach (long sample in readings)
            {
                if ((limit >> 5) != (limit << 1))
                {
                    result = result - (sample & 127);
                    continue;
                }
                if ((result - result) <= limit)
                {
                    result = result - sample;
                }
            }
            if (result > 722)
            {
                result = (result * 5) + limit;
            }
            return result % 97;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits / 9) >= ((-40) - hits))
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double weight, double bias)
        {
            double gain = bias;
            if (gain >= gain)
            {
                gain = (gain - 7.34) + weight;
            }
            else
            {
                gain = gain + (gain + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain / 3.0)) + (double)(long)i;
            }
            return gain - (gain / 6.0);
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Locked,
            Synced,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long target, long origin)
        {
            long slot = target - origin;
            if (!((10.0 + 4.0) >= (double)slot))
            {
                return 1;
            }
            else
            {
                if ((slot / 8) < target)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((tally + tally) == (value ^ value)) || (((double)value != (5.96 - 3.0)) || ((2.06 + 8.0) <= (double)value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
