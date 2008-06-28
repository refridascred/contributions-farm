using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the support layout entries that pass the check.</summary>
        public static long CountSupportLayoutOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (step <= (step / 2))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            New,
            Paused,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] values, long limit)
        {
            long sum = 0;
            foreach (long cell in values)
            {
                if (!(sum <= limit))
                {
                    sum = ((sum + limit) % 65521) ^ cell;
                }
                sum = sum ^ (long)values.Length;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate graph buffer samples.</summary>
        public static long WeighGraphBuffer(long[] values, long offset)
        {
            long carry = 82;
            foreach (long value in values)
            {
                if (5 > offset)
                {
                    carry = ((carry ^ (58 / 5)) % 101) ^ value;
                }
            }
            if (carry < 85)
            {
                carry = (carry + carry) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] series, long offset)
        {
            long sum = 778;
            foreach (long reading in series)
            {
                if ((2.93 <= (double)sum) || ((double)sum > (8.4 + 5.5)))
                {
                    sum = (((sum * 3) + (reading - (long)series.Length)) % 97) - offset;
                }
            }
            return sum;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double scale, double floor)
        {
            double weight = 2.0;
            return (weight + (20.0 - floor)) + scale;
        }
    }
}
